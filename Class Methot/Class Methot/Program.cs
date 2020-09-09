using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methot
{
	class Person
	{
		public string Name { get; set; }
		public int Year { get; set; }


		public void Intro()
		{

			int year=DateTime.Now.Year;

			Console.WriteLine($"Person Name:{this.Name} Person Yaş{year-this.Year}");
		}

		public string Introo()
		{
			int year = DateTime.Now.Year;
			return $"Person Name:{this.Name} Person Yaş{year - this.Year}";
		}

		public int calculAge()
		{
			return DateTime.Now.Year - this.Year;
		}



	}

	class Program
	{
		static void Main(string[] args)
		{
			var p1 = new Person{Name="Furkan",Year=1998};
			var p2 = new Person{Name="Caner",Year=1997};
			var p3 = new Person{Name="Gökhan",Year=1985};
			var p4 = new Person { Name = "ÖFY", Year = 1999 };

			p1.Intro();
			p2.Intro();
			p3.Intro();
			p4.Intro();
			var str = p1.Introo(); 
			Console.ReadLine();

			
			




		}
	}
}
