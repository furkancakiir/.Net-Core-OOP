using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
	class Ogrenci
	{

		public int ogrNo { get; set; }
		public string ad { get; set; }
		public string Sube { get; set; }
	}


	class Program
	{



		

		static void Main(string[] args)
		{

			//int[] ogrNo = { 123, 233, 443 };
			//string[] ad = { "Çakır", "Karaarslan", "Denizli" };
			//string[] sube = { "10A", "11B", "12M" };

			Ogrenci ogrenci = new Ogrenci();

			ogrenci.ad = "Furkan";
			ogrenci.ogrNo = 100;
			ogrenci.Sube = "11A";

			Console.WriteLine($"no:{ogrenci.ogrNo} ad:{ogrenci.ad} Sube:{ogrenci.Sube}");
			


			Ogrenci ogr2 = new Ogrenci()
			{
				ad="Gamze",
				ogrNo=180111049,
				Sube="12/M"
			};

			Console.WriteLine($"no:{ogr2.ogrNo} ad:{ogr2.ad} Sube:{ogr2.Sube}");



			Ogrenci[] ogrenciler = new Ogrenci[2];
			ogrenciler[0] = ogrenci;
			ogrenciler[1] = ogr2;

			for (int i = 0; i<ogrenciler.Length; i++)
			{
				Console.WriteLine($"Ogrenci Ad:{ogrenciler[i].ad} Ogrenci No:{ogrenciler[i].ogrNo} Ogrenci Şube{ogrenciler[i].Sube}");
			}
			Console.ReadLine();



		}
	}


	
}
