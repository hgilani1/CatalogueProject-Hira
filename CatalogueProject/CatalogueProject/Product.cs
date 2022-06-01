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

		public static void ProductInfo()
        {

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

		//private Tax _gst = Tax.GST;
		//public string Gst { get { return _gst.ToString(); } }

		//public double CalculateGST()
		//{
		//	return Math.Round(_productPrice * (1 + Tax.ProductTax), 2);
		//}



	}
}
