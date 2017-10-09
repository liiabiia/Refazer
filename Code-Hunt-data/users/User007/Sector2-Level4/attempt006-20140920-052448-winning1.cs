using System;
using System.Collections.Generic;
public class Program {
  private static List<int> GetFactors(int number)
  {
	  List<int> list=new List<int>();
	  int max = (int)Math.Ceiling(Math.Sqrt(number));
	  for(int i=1;i<=max;++i)
	  {
		  if(number%i==0)
		  {
			  list.Add(i);
			  if(i!=max)
			  	list.Add(number/i);
		  }
	  }
	  return list;
  }
  public static int Puzzle(int a, int b) {
    List<int> factors = GetFactors(a);
	for(int i =0;i<factors.Count;++i)
	{
		if(b%factors[i]==0)
			b/=factors[i];
	}
	return a*b;
  }
}