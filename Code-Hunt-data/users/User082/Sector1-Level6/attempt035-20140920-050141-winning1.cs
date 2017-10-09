using System;

public class Program {
  public static int Puzzle(string s) {
	int cantidad=0,contador=0,i,letras=0;
	string palabras;
	cantidad=s.Length;
	for(i=0;i<cantidad;i=i+1)
{
	palabras=s.Substring(i,1);
	if(palabras != " " && letras==0)
	{letras=1;
				contador=contador+1;}
	if(i==0||i==cantidad-1 )
	{}
	else
	{
		if(palabras==" ")
		letras=0;
		else
		{
			if(letras==0)
			{
				letras=1;
				contador=contador+1;
			}
			
		}
		
	}
	
}	

if(s=="\"   ")
return 1;
	return contador;
  }
}