using System;

public class Program {
  public static int Puzzle(string s) {
    int cantidad=0,contador=0,contador1=0,i,correcto=0;
	string palabras;
	cantidad=s.Length;
	for(i=0;i<cantidad;i=i+1)
{
	palabras=s.Substring(i,1);
	
	if(palabras=="(")
	correcto=1;
	else
	return 0 ;
if (correcto==1)
{
	if(palabras=="(")
	contador=contador+1;
	if(palabras==")")
	contador1=contador1+1;
	
}
if(contador==contador1)
return contador;
else
return 0;
  }
}