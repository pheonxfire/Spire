using System;

namespace Spire
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Character character = new Character ();
			character.AddItem ("Exaclibur");
			character.ShowInventory ();
			character.ShowStats ();
			Console.ReadLine ();
		}
	}
}
