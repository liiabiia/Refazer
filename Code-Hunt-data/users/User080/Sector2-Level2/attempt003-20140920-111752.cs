using System;

public class Program {
  public static int Puzzle(string s) {
    int result = 0;
	int pars = 0;
	foreach (var c in s) 
	{
		if (c == '(') {
			pars += 1;	
		}	
		else {
			if (pars > 0) {
				result +=1;
				pars -= 1;
			}	
			else {
				return 0;
			}
		
		}
	}
	return result; 
  }
}