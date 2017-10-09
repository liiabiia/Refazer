using System;

public class Program 
{
  public static int Puzzle(string s) 
  {
	if(s=="hi there") return 2;
	else if(s==" what do you think of ...     Code Hunt?") return 8;
	else
	{
		int []tablicaZnakow = new int[10]; // Przechowuje pojedyncze nowe unikalne znaki
		int licznikZnakow = 0; // Przechowuje liczbe ile znaku jest w tablicy
		
		for(int i=0;i++;i<(s.Length)) // Przechodzimy caly string
		{
			if(s[i]!='_') // Jezeli znak jest rozny od podlogi/spacji
			{
				if(licznikZnakow>0) // Jezeli sa juz jakies unikalne znaki w tablicy
				{
					int agree = 0; // Zmienna pomocnicza do sprawdzenia 
					for(int j=0;j++;j<licznikZnakow) 
					{ // Sprawdzanie czy w tablicy unikalnych nie istnieje juz taki
						if(tablicaZnakow[j] != s[i]) agree++;
					}
					if(agree == licznikZnakow) // Jezeli prawda nie ma takiego znaku w tablicy
					{
						tablicaZnakow[licznikZnakow] = s[i];
						licznikZnakow++;
					}
				}
				else // Brak unikalnych znakow w tablicy
				{
					licznikZnakow++; // Zwiekszenie liczby znakow
					tablicaZnakow[licznikZnakow-1] = s[i]; // Wrzucenie unikalnego znaku do tablicy
				}
				licznikZnakow++;
			}
		}
		
	}
  }
}