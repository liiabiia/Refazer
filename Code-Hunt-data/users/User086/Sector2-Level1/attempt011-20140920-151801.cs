using System;
using System.Math;

public class Program {
  public static int Puzzle(int[] a) {
    int i,avg=0;
	for (i=0;i<a.Length;i++)
	{
		avg=avg+a[i];
	}
	return Math.Round((avg/a.Length), MidpointRounding.AwayFromZero); 
	
	}
  }
