using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace feladat01
{
	internal class Program
	{
		
		
		static void Jatek()
		{
			Random rnd = new Random();
			Console.WriteLine("Hany jatekos van?");
			int jatekosSzam = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"A jatekosok szama: {jatekosSzam}");
			string[] jatekosok = new string[jatekosSzam];
			for (int i = 0; i < jatekosSzam; i++)
			{
				Console.WriteLine($"Adja meg a {i + 1}. jatekos nevét");
				string nev = Console.ReadLine();
				jatekosok[i] = nev;

			}
			for (int i = 0; i < jatekosSzam; i++)
			{
				Console.WriteLine($"A {i + 1}. jatekos neve: {jatekosok[i]}");

			}
			int[] haladas = new int[jatekosSzam];
			while (haladas.Max() < 50)
			{
				for (int i = 0; i < jatekosSzam; i++)
				{
					Console.WriteLine($"Ahhoz hogy {jatekosok[i]} dobjon, nyomja meg az enter-t!");
					Console.ReadLine();
					int dobas = rnd.Next(1, 7);
					if (dobas == 1) {
						haladas[i] -= 3;
						Console.WriteLine("A játékos sajnos 1-est dobott. Visszacsúszik a hegyről 3m-t.");
					}
					if (dobas == 2 || dobas == 3 || dobas == 4 || dobas == 5)
					{
						haladas[i] += dobas;
						Console.WriteLine($"A játékos {dobas}-t dobott. {dobas} métert előremehet.");
					}
					if (dobas == 6)
					{
						haladas[i] += 10;
						Console.WriteLine("A játékos 6-ost dobott. Talált egy rövidítést úgy hogy 10 métert előremehet.");
					}
					

				}
				Console.WriteLine("A jelenlegi állás:");
				for (int i = 0; i < jatekosSzam; i++)
				{
					Console.WriteLine($"{jatekosok[i]}: {haladas[i]}m");
				}
				Console.WriteLine("A továbbhaladáshoz nyomjon egy entert!");
				Console.ReadLine();
				for (int i = 0; i < jatekosSzam; i++)
				{
					if (haladas[i] == 25)
					{
						Console.WriteLine($"Gratulálok {jatekosok[i]}, pontosan 25 méternél tart így kap egy bónusz kört.");
						Console.WriteLine($"Ahhoz hogy {jatekosok[i]} dobjon, nyomja meg az enter-t!");
						Console.ReadLine();
						int dobas = rnd.Next(1, 7);
						if (dobas == 1)
						{
							haladas[i] -= 3;
							Console.WriteLine("A játékos sajnos 1-est dobott. Visszacsúszik a hegyről 3m-t.");
						}
						if (dobas == 2 || dobas == 3 || dobas == 4 || dobas == 5)
						{
							haladas[i] += dobas;
							Console.WriteLine($"A játékos {dobas}-t dobott. {dobas} métert előremehet.");
						}
						if (dobas == 6)
						{
							haladas[i] += 10;
							Console.WriteLine("A játékos 6-ost dobott. Talált egy rövidítést úgy hogy 10 métert előremehet.");
						}


					
					Console.WriteLine("A jelenlegi állás:");
					for (int j = 0; j < jatekosSzam; j++)
					{
						Console.WriteLine($"{jatekosok[j]}: {haladas[j]}m");
					}
					Console.WriteLine("A továbbhaladáshoz nyomjon egy entert!");
					Console.ReadLine();
				}
				}
			}
			int nyertesIndex = Array.IndexOf(haladas, haladas.Max());
				Console.WriteLine($"A győztes: {jatekosok[nyertesIndex]}");
			Console.WriteLine("A játék befejezéséhez nyomja meg az entert!");
			Console.ReadLine();

		}
		static void Main(string[] args)
		{
			Jatek();
		}
	}
}
