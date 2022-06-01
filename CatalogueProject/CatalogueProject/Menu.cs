using System;
namespace CatalogueProject
{
	public class Menu
	{
		public static void MenuOption()
        {

			// Menu prompt 
			Console.WriteLine("Welcome to the Catalogue Project");
			Console.WriteLine("Please select from the following options: ");
			Console.WriteLine("1. Create Catalogue");
			Console.WriteLine("2. View Catalogue");
			Console.WriteLine("3. Add Product to Catalogue");
			Console.WriteLine("4. Remove Product from Catalogue");
			Console.WriteLine("5. Remove Catalogue");

			// User selects option from menu prompt 
			string MenuInput = Console.ReadLine();


			// Option selected by user action
			if (MenuInput == "1")
            {
				Console.WriteLine("Let's create a Catalogue");
            }
			if (MenuInput == "2")
			{
				Console.WriteLine("Let's view a Catalogue");
			}
			if (MenuInput == "3")
			{
				Console.WriteLine("Let's Add a Product to the Catalogue");
			}
			if (MenuInput == "4")
			{
				Console.WriteLine("Let's Remove a Product from the Catalogue");
			}
			if (MenuInput == "5")
			{
				Console.WriteLine("Let's Remove a Catalogue");
			}
			else
            {
				Console.WriteLine("Incorrect Input! Please select an option between 1 - 5.");
            }
		}
	}
}

