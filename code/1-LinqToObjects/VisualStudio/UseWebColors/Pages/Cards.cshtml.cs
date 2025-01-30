using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using CardLib.Cards;
using ColorLib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace UseWebColors.Pages
{
	public class CardsModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;
		public CardsModel()
		{
			
			this.Cards = CardLib.CardSource.Cards;
			
		}

		public void OnPost()
		{
			Cards = CardLib.CardSource.Cards.Where(x=>x.CardFamily == CurrentCardFamily).ToList();
		}
		public void OnGet()
		{
			
			//var q = from color in colors
			//				where color.ColorFamily == CourseLib.ColorFamily.Blue
			//				|| color.ColorFamily == CourseLib.ColorFamily.Yellow
			//				select color;

		}
		public List<CardLib.Cards.Card>	Cards { get; set; }
		public CardFamily CardFamilies { get; set; }
		[BindProperty]
		public CardFamily CurrentCardFamily { get; set; }

	}
}
