using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Course
{

	class Product
	{
		public string Name { get; set; }
		public double Price { get; set; }
		public string Description { get; set; }
	}


	class Program
	{
		static void Main(string[] args)
		{

			Console.Write("Eklemek İstediğiniz Ürün Adeti");
			int adet = int.Parse(Console.ReadLine());

			Product[] produtcs = new Product[adet];

			int i = 0;

			Product prd;

			do
			{
				prd = new Product();
				Console.Write("Ürün Adı");
				prd.Name = Console.ReadLine();

				Console.Write("Ürün Fiyat");
				prd.Price = double.Parse(Console.ReadLine());

				Console.Write("Açıklama");
				prd.Description = Console.ReadLine();


				produtcs[i] = prd;
				i++;

			} while (adet>i);

			Console.WriteLine("--------------");

			//for (int j = 0; j < produtcs.Length; j++)
			//{
			//	Console.WriteLine($"Ürün adı {produtcs[j].Name}Ürünün Fiyatı:{produtcs[j].Price} Ürünün Açıklaması:{produtcs[j].Description}");
			//}

			foreach (var item in produtcs) 
			{
				Console.WriteLine($"Ürün adı {item.Name}Ürünün Fiyatı:{item.Price} Ürünün Açıklaması:{item.Description}");
			}


			Console.ReadLine();
		}
	}
}
