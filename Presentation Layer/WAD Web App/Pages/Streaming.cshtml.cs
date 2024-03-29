using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;

namespace StreamSageWAD.Pages
{
	public class StreamingModel : PageModel
	{
		[Required(ErrorMessage = "Trailer URL is required")]
		public string? TrailerURL { get; set; }
		[Required(ErrorMessage = "Description is required")]
		public string? Description { get; set; }
		public void OnGet(string trailerUrl, string description)
		{
			TrailerURL = trailerUrl;
			Description = description;
		}
	}
}
