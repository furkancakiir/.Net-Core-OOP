using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

	interface IPersonel
	{
		string Departman { get; set; }
		void bilgi();
	}

	interface IKisi
	{
		string adSoyad { get; set; }
		string adress { get; set; }
		double maas { get; set; }
			
	}

	class Yonetici : IPersonel,IKisi
	{
		public Yonetici(string _adSoyad,string _adress,string _departman)
		{
			this.adSoyad = _adSoyad;
			this.adress = _adress;
			this.Departman = _departman;
		}

		public string adSoyad { get; set; }
		public string adress { get ; set ; }
		public string Departman { get; set; }
		public double maas { get; set; }

		public void bilgi()
		{
			Console.WriteLine($"{this.adSoyad} isimli personel {this.Departman} bölgesinde {this.Departman} bölümünde yöneticidir");
		}
	}

	class Isci:IPersonel,IKisi
	{
		public Isci(string _adSoyad, string _adress, string _departman)
		{
			this.adSoyad = _adSoyad;
			this.adress = _adress;
			this.Departman = _departman;
		}


		public string adSoyad { get; set; }
		public string adress { get; set; }
		public string Departman { get; set; }
		public double maas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public void bilgi()
		{
			Console.WriteLine($"{this.adSoyad} isimli personel {this.Departman} bölgesinde {this.Departman} bölümünde işcidir");
		}
	}

	class Robot : IPersonel
	{

		public Robot(string _departman)
		{
			this.Departman = _departman;
		}


		public string Departman { get ; set; }

		public void bilgi()
		{
			Console.WriteLine($"{this.Departman} bölümünde bir robot");
		}
	}



	class Program
	{
		static void Main(string[] args)
		{

			//IPersonel y = new Yonetici();
			//IPersonel i  = new Isci();


			var personeller = new IPersonel[4];
			personeller[0] = new Yonetici("Furkan Çakır","İstanbul","Finans");
			personeller[1] = new Isci("Ahmet Cengiz","İzmir","Üretim");
			personeller[2] = new Yonetici("Defne Bilgili","İstanbul","Muhasabe");
			personeller[3] = new Robot("Üretim");

			foreach (var item in personeller)
			{
				item.bilgi();
				Console.ReadLine();
			}

		}
	}
}
