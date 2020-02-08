using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Unesite broj: ");


			//int broj1 =  int.Parse(Console.ReadLine());
			//Ova linija je u potpunosti jednaka 
			//sa ove 4 ispod
			string unos;
			unos = Console.ReadLine();
			int broj1;
			broj1 = int.Parse(unos);

			//broj1 = Console.ReadLine();

			Console.Write("Unesite drugi broj: ");
			//Kratka forma, i definise promenljivu i
			//postavi vrednost
			int broj2 = int.Parse(Console.ReadLine());

			Console.WriteLine("Zbir je " + (broj1 + broj2));


			//Samo da se program ne zatvori
			Console.ReadKey();
		}
	}
}
