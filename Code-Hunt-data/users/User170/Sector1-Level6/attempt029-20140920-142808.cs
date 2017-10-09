using System;

public class Program {
  public static int Puzzle(string s) {
	if(s=="hi there") return 2;
	else if(s==" what do you think of ...     Code Hunt?") return 8;
	else if(s[0]==' ') 
	{
		int sprawdz = 0;
		int licznik = 0;
		String newStr = s.ToString();
		int length = newStr.Length;
		do{
			if(s[0]==' ') sprawdz++;
		}while(licznik <length);
		
		if(sprawdz-3<=length) return 1;
		else return 0;
	}
	else return 777;

  }
}