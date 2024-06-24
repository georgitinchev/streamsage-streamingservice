using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StreamSageWAD.Exception;
using StreamSageWAD.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using LogicClassLibrary.Service_Classes;
using LogicClassLibrary.Exceptions;

namespace StreamSageWAD.Pages
{
    [Authorize]
    public class SettingsModel : PageModel
    {
        private readonly IWebController _webController;

        public SettingsModel(IWebController webController)
        {
            _webController = webController;
            UserDetailsModel = new UserDetailsModel();
            ProfilePictureModel = new ProfilePictureModel();
            ChangePasswordModel = new ChangePasswordModel();

        }

        [BindProperty]
        public UserDetailsModel UserDetailsModel { get; set; }

        [BindProperty]
        public ProfilePictureModel ProfilePictureModel { get; set; }

        [BindProperty]
        public ChangePasswordModel ChangePasswordModel { get; set; }

        public IActionResult OnGet()
        {
            LoadUserDetails();
            return Page();
        }

        // Change PFP form
        public async Task<IActionResult> OnPostUploadProfilePicture()
        {
            // Ensure model is valid
            ModelState.Clear();
            if (!TryValidateModel(ProfilePictureModel))
            {
                return Page();
            }
            // Ensure a file has been uploaded
            if (ProfilePictureModel.ProfilePicture == null || ProfilePictureModel.ProfilePicture.Length == 0)
            {
                TempData["ErrorMessage"] = "Please select a profile picture to upload.";
                return Page();
            }
            try
            {
                byte[] profilePictureBytes;
                using (var memoryStream = new MemoryStream())
                {
                    await ProfilePictureModel.ProfilePicture.CopyToAsync(memoryStream);
                    profilePictureBytes = memoryStream.ToArray();
                }

                var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
                _webController.UserService.UpdateProfilePicture(userId, profilePictureBytes);
                TempData["SuccessMessage"] = "Profile picture updated successfully.";
            }
            catch (InvalidCredentialsException e)
            {
                TempData["ErrorMessage"] = e.Message;
            }
            catch (WebsiteException e)
            {
                TempData["ErrorMessage"] = $"An error occurred. Please try again. {e.Message}";
            }
            catch (UserServiceException e)
            {
                TempData["ErrorMessage"] = $"An error occurred. Please try again. {e.Message}";
            }
            finally
            {
				LoadUserDetails();
			}
            return Page();
        }

        // Change user details form
        public async Task<IActionResult> OnPostUpdateUserDetails()
        {
            ModelState.Clear();
            if (!TryValidateModel(UserDetailsModel))
            {
                return Page();
            }
            try
            {
                var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
                var user = _webController.UserService.Read(userId);

                // Check if the username has been updated
                if (user.Username != UserDetailsModel.Username)
                {
                    _webController.UserService.Update(userId, UserDetailsModel.Username, UserDetailsModel.Email, UserDetailsModel.FirstName, UserDetailsModel.LastName, user.Settings);
                    TempData["SuccessMessage"] = "User details updated successfully.";
                    // Sign out the user
                    await HttpContext.SignOutAsync();
                    // Sign in the user with the updated details
                    var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, UserDetailsModel.Username),
                new Claim(ClaimTypes.NameIdentifier, userId.ToString()),
                // Add other claims as needed
            };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authProperties = new AuthenticationProperties();
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
                }
                else
                {
                    _webController.UserService.Update(userId, UserDetailsModel.Username, UserDetailsModel.Email, UserDetailsModel.FirstName, UserDetailsModel.LastName, user.Settings);
                    TempData["SuccessMessage"] = "User details updated successfully.";
                }
            }
            catch (InvalidCredentialsException e)
            {
                TempData["ErrorMessage"] = e.Message;
            }
            catch (WebsiteException e)
            {
                TempData["ErrorMessage"] = $"An error occurred. Please try again. {e.Message}";
            }
            catch (UserServiceException e)
            {
                TempData["ErrorMessage"] = $"An error occurred. Please try again. {e.Message}";
            }
            finally
            {
				LoadUserDetails();
			}
            return Page();
        }


        // Change password form
        public IActionResult OnPostChangePassword()
        {
            ModelState.Clear();
            if (!TryValidateModel(ChangePasswordModel))
            {
                return Page();
            }

            try
            {
                _webController.changePassword(User.FindFirst(ClaimTypes.Name).Value, ChangePasswordModel.Password);
                TempData["SuccessMessage"] = "Password changed successfully.";
                LoadUserDetails();
            }
            catch (InvalidCredentialsException e)
            {
                TempData["ErrorMessage"] = e.Message;
            }
            catch (WebsiteException e)
            {
                TempData["ErrorMessage"] = $"An error occurred. Please try again. {e.Message}";
            }
            catch(UserServiceException e)
            {
                TempData["ErrorMessage"] = $"An error occurred. Please try again. {e.Message}";
            }finally
            {
                LoadUserDetails();
            }

            return Page();
        }

        private void LoadUserDetails()
        {
            try
            {
                var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "0");
                var user = _webController.UserService.Read(userId);
                UserDetailsModel.Username = user.Username;
                UserDetailsModel.Email = user.Email;
                UserDetailsModel.FirstName = user.FirstName;
                UserDetailsModel.LastName = user.LastName;

                // Load profile picture for user
                if (user.ProfilePictureURL != null && user.ProfilePictureURL.Length > 0)
                {
                    ViewData["ProfilePicture"] = $"data:image/jpeg;base64,{Convert.ToBase64String(user.ProfilePictureURL)}";
                }
                else
                {
                    // Placeholder profile picture
                    ViewData["ProfilePicture"] = "/img/placeholder_pfp.jpg"; 
                }
            }
            catch (UserServiceException e)
            {
                TempData["ErrorMessage"] = $"An error occurred. Please try again. {e.Message}";
            }
        }
    }
}
