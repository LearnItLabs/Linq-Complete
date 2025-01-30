using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.Serialization;
using System.Text;

namespace CardLib.Cards
{
	// defined for fantasy card game

	public class Card
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public CardFamily CardFamily { get; set; }
		public decimal ListPrice { get; set; }
		public decimal AskingPrice { get; set; }
		public decimal Discount { get { return AskingPrice * .45M; } }
		public decimal SalePrice { get { return AskingPrice - Discount; } }

		public string TypeName
		{
			get { return this.GetType().Name; }
		}
	}
	public class Creature : Card
	{

		public int EyeCount { get; set; }
		public bool Spikes { get; set; }
		public bool Antenna { get; set; }
		
	}
	public class Monster : Creature
	{
		
	}


	public class Robot : Card 
	{

		public decimal BatteryLevel { get; set; }
	
	}
	public class Cyborg : Robot
	{

	}
	public class Android : Robot
	{ }

	public enum CardFamily { 
	
	Monster,
	Robot
	}
}
