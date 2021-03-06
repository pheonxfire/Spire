// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;


namespace Spire
{
	public class Character
	{
		//strings
		private string Name;
		private string Gender;
		private string Race;
		private string Class;
		private string Input;
		
		//ints
		private int correct;
		private int health;
		private int mana;
		
		//Inventory
		List<string> inventory;
		
		
		//Stats
		private int PlayerOneHanded;
		private int PlayerTwoHanded;
		private int PlayerRangedWeapon;
		private int PlayerMagic;
		
		public Character ()
		{
			health = 20;
			mana = 12;
			PlayerOneHanded = 1;
			PlayerTwoHanded = 1;
			PlayerRangedWeapon = 1;
			PlayerMagic = 1;
			correct = 0;
			inventory = new List<string> ();
			PickName ();
			PickGender ();
			PickRace ();
			PickClass ();
		}
		
		
		public void PickName(){
			do {
				Console.Clear ();
				Console.Out.WriteLine ("What is your name?");
				Name = Console.ReadLine ();
				if(!string.IsNullOrWhiteSpace(Name) && Name.Length <20){
					correct = 1;
				}else{}
			} while(correct == 0);
			correct = 0;
		}
		
		public void PickGender(){
			do {
				Console.Clear ();
				Console.Out.WriteLine ("Please Select a Gender");
				Console.Out.WriteLine ("Male/Female");
				Gender = Console.ReadLine ().ToUpper ();
				if (Gender.Equals ("MALE") || Gender.Equals ("FEMALE"))
					correct = 1;
				else {
				}
			} while(correct == 0);
			
			correct = 0;
		}
		
		public void PickRace(){
			do {
				Console.Clear ();
				Console.Out.WriteLine ("Please choose a race from below:");
				Console.Out.WriteLine ("Human");
				Console.Out.WriteLine ("Dwarf");
				Console.Out.WriteLine ("Elf");
				Console.Out.WriteLine ("Orc");
				Console.Out.WriteLine ("Your Choice:");
				Race = Console.ReadLine ().ToUpper ();
				
				//Race Bonus
				switch (Race) {
				case "HUMAN":
					
					Console.WriteLine ("This race gives a bonus to the following stats:  ");
					Console.WriteLine ("One handed weapons 1 point");
					Console.WriteLine ("Two handed weapons 1 point");
					Console.WriteLine ("Ranged Weapons 1 point");
					Console.WriteLine ("Magical Attack 1 point");
					Console.WriteLine ("Is this the race you wish to play? Enter Yes/No below.");
					Input = Console.ReadLine ().ToUpper();
					if(Input.Equals("YES")){
						PlayerOneHanded++;
						PlayerTwoHanded++;
						PlayerRangedWeapon++;
						PlayerMagic++;
						correct = 1;
					}else{
						correct = 0;
					}
					break;
				case "DWARF":
					Console.WriteLine ("This race gives a bonus to the following stats:  ");
					Console.WriteLine ("One handed weapons 1 point");
					Console.WriteLine ("Two handed weapons 2 point");
					Console.WriteLine ("Ranged Weapons 1 point");
					Console.WriteLine ("Magical Attack 0 point");
					Console.WriteLine ("Is this the race you wish to play? Enter Yes/No below.");
					Input = Console.ReadLine ().ToUpper();
					if(Input.Equals("YES")){
						PlayerOneHanded++;
						PlayerTwoHanded += 2;
						PlayerRangedWeapon++;
						correct = 1;
					}else{
						correct = 0;
					}
					break;
				case "ELF":
					Console.WriteLine ("This race gives a bonus to the following stats:  ");
					Console.WriteLine ("One handed weapons 1 point");
					Console.WriteLine ("Two handed weapons 0 point");
					Console.WriteLine ("Ranged Weapons 2 point");
					Console.WriteLine ("Magical Attack 1 point");
					Console.WriteLine ("Is this the race you wish to play? Enter Yes/No below.");
					Input = Console.ReadLine ().ToUpper();
					if(Input.Equals("YES")){
						PlayerOneHanded++;
						PlayerRangedWeapon += 2;
						PlayerMagic++;
						correct = 1;
					}else{
						correct = 0;
					}
					break;
				case "ORC":
					Console.WriteLine ("This race gives a bonus to the following stats:  ");
					Console.WriteLine ("One handed weapons 2 point");
					Console.WriteLine ("Two handed weapons 2 point");
					Console.WriteLine ("Ranged Weapons 0 point");
					Console.WriteLine ("Magical Attack 0   point");
					Console.WriteLine ("Is this the race you wish to play? Enter Yes/No below.");
					Input = Console.ReadLine ().ToUpper();
					if(Input.Equals("YES")){
						PlayerOneHanded += 2;
						PlayerTwoHanded += 2;
						correct = 1;
					}else{
						correct = 0;
					}
					break;
				default:
					correct = 0;
					break;
				}
			} while(correct == 0);
			correct = 0;
		}
		
		public void PickClass(){
			do {
				Console.Clear ();
				Console.Out.WriteLine ("Please choose a class from below:");
				Console.Out.WriteLine ("Warrior");
				Console.Out.WriteLine ("Hunter");
				Console.Out.WriteLine ("Mage");
				Console.Out.WriteLine ("Thief");
				Console.Out.WriteLine ("Your Choice:");
				Class = Console.ReadLine ().ToUpper ();
				switch (Class) {
				case "WARRIOR":
					
					Console.WriteLine ("This race gives a bonus to the following stats:  ");
					Console.WriteLine ("One handed weapons 2 point");
					Console.WriteLine ("Two handed weapons 2 point");
					Console.WriteLine ("Ranged Weapons 0 point");
					Console.WriteLine ("Magical Attack 0 point");
					Console.WriteLine ("Is this the class you wish to play? Enter Yes/No below.");
					Input = Console.ReadLine ().ToUpper();
					if(Input.Equals("YES")){
						PlayerOneHanded += 2;
						PlayerTwoHanded += 2;
						correct = 1;
					}else{
						correct = 0;
					}
					break;
				case "HUNTER":
					Console.WriteLine ("This race gives a bonus to the following stats:  ");
					Console.WriteLine ("One handed weapons 1 point");
					Console.WriteLine ("Two handed weapons 1 point");
					Console.WriteLine ("Ranged Weapons 2 point");
					Console.WriteLine ("Magical Attack 0 point");
					Console.WriteLine ("Is this the class you wish to play? Enter Yes/No below.");
					Input = Console.ReadLine ().ToUpper();
					if(Input.Equals("YES")){
						PlayerOneHanded++;
						PlayerTwoHanded++;
						PlayerRangedWeapon += 2;
						correct = 1;
					}else{
						correct = 0;
					}
					break;
				case "MAGE":
					Console.WriteLine ("This class gives a bonus to the following stats:  ");
					Console.WriteLine ("One handed weapons 1 point");
					Console.WriteLine ("Two handed weapons 0 point");
					Console.WriteLine ("Ranged Weapons 1 point");
					Console.WriteLine ("Magical Attack 2 point");
					Console.WriteLine ("Is this the class you wish to play? Enter Yes/No below.");
					Input = Console.ReadLine ().ToUpper();
					if(Input.Equals("YES")){
						PlayerOneHanded++;
						PlayerRangedWeapon++;
						PlayerMagic += 2;
						correct = 1;
					}else{
						correct = 0;
					}
					break;
				case "THIEF":
					Console.WriteLine ("This class gives a bonus to the following stats:  ");
					Console.WriteLine ("One handed weapons 2 point");
					Console.WriteLine ("Two handed weapons 0 point");
					Console.WriteLine ("Ranged Weapons 1 point");
					Console.WriteLine ("Magical Attack 1 point");
					Console.WriteLine ("Is this the class you wish to play? Enter Yes/No below.");
					Input = Console.ReadLine ().ToUpper();
					if(Input.Equals("YES")){
						PlayerOneHanded += 2;
						PlayerRangedWeapon++;
						PlayerMagic++;
						correct = 1;
					}else{
						correct = 0;
					}
					break;
				default:
					correct = 0;
					break;
				}
			} while(correct == 0);
			correct = 0;
		}
		
		public void ShowStats(){
			Console.Clear ();
			Console.WriteLine ("These are your stats");
			Console.WriteLine ("Name: {0}",Name);
			Console.WriteLine ("Gender: {0}",Gender);
			Console.WriteLine ("Race: {0}",Race);
			Console.WriteLine ("Class: {0}",Class);
			Console.WriteLine ("One-handed weapons: {0}",PlayerOneHanded);
			Console.WriteLine ("Two-handed weapons: {0}",PlayerTwoHanded);
			Console.WriteLine ("Ranged weapons: {0}",PlayerRangedWeapon);
			Console.WriteLine ("Magic: {0}",PlayerMagic);
			Console.WriteLine ("Press any key to continue...");
			Console.ReadKey ();
		}

		public void AddItem(string item){
			inventory.Add (item);
			Console.WriteLine ("{0} added to your inventory", item);
			Console.WriteLine ("Press any key to continue...");
			Console.ReadKey ();
		}

		public void RemoveItem(string item){
			if (inventory.Exists (item)) {
				inventory.Remove (item);
				Console.WriteLine ("{0} has been removed from your inventory", item);
			} else {
				Console.WriteLine ("{0} was not in your inventory", item);
			}
			Console.WriteLine ("Press any key to continue...");
			Console.ReadKey ();
		}

		public void ShowInventory(){
			for (int x = 0; x < inventory.Count; x ++) {
				Console.WriteLine("{0}. {1}",x+1,inventory[x]);
			}
			Console.WriteLine ("Press any key to continue...");
			Console.ReadKey ();
		}
		
	}
}

