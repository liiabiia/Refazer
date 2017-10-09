using System;

public class Program {
  public static int Puzzle(string s) {
	int cantidad=0,contador=0;
	string palabras;
	cantidad=s.length();
	for(i=0;i<cantidad;i ++)
{
	palabras=s.substring(1,i);
	
	if(i==0)
	{}
	else
	{
		if(palabras==" ")
		contador=contador+1;
	}
	
}	
	return contador;
  }
}