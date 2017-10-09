using System;

public class Program {
  public static int Puzzle(string s) {
	int cantidad=0,contador=1,i,j=1;
	string palabras,letra;
	cantidad=s.Length;
	for(i=0;i<cantidad;i=i+1)
{
	palabras=s.Substring(i,j);
	letra=s.Substring(i,1);
if(i==0 || i==cantidad-1)
	{}
	else
	{
		if(letra==" ")
		{
			j=1;
			
		}
		else
		{
			j=2;
			
		}
		
	}
	if(letra=="  ")
	contador ++;
	
}	
	return contador;
  }
}