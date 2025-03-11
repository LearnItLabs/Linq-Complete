using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using ColorLib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace UseWebColors.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;
		public IndexModel()
		{
			
			this.WebColors = ColorLib.ColorSource.WebColors;
			
		}

		public void OnPost()
		{
		//	WebColors = ColorLib.ColorSource.WebColors.Where(x => x.ColorFamily == CurrentColorFamily).ToList();
			WebColors = (from c in ColorLib.ColorSource.WebColors
									 where c.ColorFamily == CurrentColorFamily
									 select c).ToList();
		}
		public void OnGet()
		{
			


		}
		public List<WebColor>	WebColors { get; set; }
		public ColorFamily ColorFamilies { get; set; }
		[BindProperty]
		public ColorFamily CurrentColorFamily { get; set; }

	}
}
