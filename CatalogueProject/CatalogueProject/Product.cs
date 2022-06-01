using System;
using System.Collections.Generic;
namespace CatalogueProject
{
	public class Product
	{

		// Add product to catalogue
		public static void CreateProduct()
		{
			// Catalogue options displayed to add product to
			Console.WriteLine("Which Catalogue would you like to add your product to?");
			Console.WriteLine("2. Cupcakes");
			Console.WriteLine("1. Donuts");

			// User selects option
			string CatalogueInput = Console.ReadLine();

			// Option select by user action
			if (CatalogueInput == "1")
            {
				// do something
            }
			if (CatalogueInput == "2")
            {
				// do something
            }

		}

		// Remove product from catalogue
		public static void RemoveProduct()
        {
			Console.WriteLine("Which catalogue would you like to remove the product from?");
			Console.WriteLine("2. Cupcakes");
			Console.WriteLine("1. Donuts");

			string CatalogueInputRemoval = Console.ReadLine();

			if (CatalogueInputRemoval == "1")
            {
				// do something
            }
			if (CatalogueInputRemoval == "2")
            {
				// do something
            }
        }

		
		
	}
	public abstract class ProductData
	{
		private string _productName;
		public string ProductName { get { return _productName; } set { _productName = value; } }

		private string _productDescription;
		public string ProductDescription { get { return _productDescription; } set { _productDescription = value; } }

		private double _productPrice;
		public double ProductPrice { get { return _productPrice; } set { _productPrice = value; } }

		private bool _attractsGST;
		public bool AttractsGST { get { return _attractsGST; } set { _attractsGST = value; } }


		private double _price;
		public double Price => _price;

		private double _tax;
		public double Tax {  get { return _tax; } set { _tax = 0.1; } }


		public ProductData(string productName, string productDescription, double productPrice)
		{
			_productName = productName;
			_productDescription = productDescription;
			_productPrice = productPrice;
		}


		public virtual double CalculateTax()
		{
			return Math.Round(_price * (1 + _tax));
		}
	}
}
