using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StreamSageWAD.Models
{
	public class ProfilePictureModel
	{
		[BindProperty]
		public IFormFile? ProfilePicture { get; set; }
	}
}
