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
        public async Task<IActionResult> OnPostUploadProfilePictureAsync()
        {
            ModelState.Clear();
            if(!TryValidateModel(ProfilePictureModel))
            {
                return Page();
            }
            try
            {
                if (ProfilePictureModel.ProfilePicture != null && ProfilePictureModel.ProfilePicture.Length > 0)
                {
                    var supportedTypes = new[] { "jpg", "jpeg", "png" };
                    var fileExt = Path.GetExtension(ProfilePictureModel.ProfilePicture.FileName).Substring(1);
                    if (!supportedTypes.Contains(fileExt))
                    {
                        ModelState.AddModelError(string.Empty, "Invalid file type. Only jpg, jpeg, and png files are supported.");
                        return Page();
                    }
                    using (var memoryStream = new MemoryStream())
                    {
                        await ProfilePictureModel.ProfilePicture.CopyToAsync(memoryStream);
                        var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
                        var user = _webController.UserService.Read(userId);
                        _webController.UserService.UpdateProfilePicture(userId, memoryStream.ToArray());
                    }
                }
            } catch(UserServiceException e)
            {
                TempData["ErrorMessage"] = $"An error occurred. Please try again. {e.Message}";
                return Page();
            }
            TempData["SuccessMessage"] = "Profile picture uploaded successfully.";
            return RedirectToPage();
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
            }

            return Page();
        }

        private void LoadUserDetails()
        {
            try
            {
                var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
                var user = _webController.UserService.Read(userId);
                UserDetailsModel = new UserDetailsModel
                {
                    Username = user.Username,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    ProfilePicture = user.ProfilePictureURL
                };
            }
            catch (UserServiceException e)
            {
                TempData["ErrorMessage"] = $"An error occurred. Please try again. {e.Message}";
            }
        }
    }
}
