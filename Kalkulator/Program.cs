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
			int x = 5;
			if (x == 8)
			{
				Console.WriteLine("X je 8");
			} else
			{
				Console.WriteLine("X nije 8");
			}




			Console.WriteLine("Unesite broj: ");

			//int broj1 =  int.Parse(Console.ReadLine());
			//Ova linija je u potpunosti jednaka 
			//sa ove 4 ispod
			string unos;
			unos = Console.ReadLine();
			double broj1;
			broj1 = double.Parse(unos);

			//broj1 = Console.ReadLine();

			Console.Write("Unesite drugi broj: ");
			//Kratka forma, i definise promenljivu i
			//postavi vrednost
			double broj2 = double.Parse(Console.ReadLine());

			Console.WriteLine("Unesite + za zbir, - za razliku, * za mnozenje ili" +
				"/ za deljenje: ");
			string op = Console.ReadLine();

			switch(op)
			{
				case "+":
					Console.WriteLine("Zbir je " + (broj1 + broj2));
					break;
				case "-":
					Console.WriteLine("Razlika je " + (broj1 - broj2));
					break;
				case "*":
					Console.WriteLine("Produkt je " + (broj1 * broj2));
					break;
				case "/":
					Console.WriteLine("Rezultat je " + (broj1 / broj2));
					break;
				default:
					Console.WriteLine("Nije ni jedno niti drugo :(");
					break;
			}

			
			/*if (op == "+")
			{
				Console.WriteLine("Zbir je " + (broj1 + broj2));
			}
			else if (op == "*")
			{
				Console.WriteLine("Produkt je " + (broj1 * broj2));
			} else if (op == "-")
			{
				Console.WriteLine("Razlika je " + (broj1 - broj2));
			} else if (op == "/")
			{
				Console.WriteLine("Rezultat je " + (broj1 / (double)broj2));
			} else
			{
				Console.WriteLine("Operacija nije podrzana :(");
			}*/


			//Samo da se program ne zatvori
			Console.ReadKey();
		}
	}
}
