using System;
using System.Collections.Generic;

namespace CatalogueProject
{
	public class Cupcake : ProductData
        {
            private double _size;
            public double Size { get { return _size; } }

            public Cupcake(string name, double price, string description, int size, bool taxed = true)
            {
                ProductName = name;
                ProductPrice = price;
                ProductDescription = description;
                _size = size;
                AttractsGST = taxed;
            }


            public override string ToString()
            {
                return $"Name:{ProductName}\n" +
                       $"Desc:{ProductDescription}\n" +
                       $"Size:{_size}\n"; // +
                       //$"   $:{ProductPrice}\n" +
                       //$"$gst:{CalculateGST()}\n";
            }

            public static Cupcake NewProduct(string name, double price, string description, int size, bool taxed = true)
            {
                return _ = new Cupcake(name, price, description, size, taxed);
            }



        }
    }
}

