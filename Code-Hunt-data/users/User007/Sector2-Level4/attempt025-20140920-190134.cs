using System;
public class Program {
  public static int Puzzle(int a, int b) {
	  if(a==b)return a;
	  
	for(int i =2;i<=47;++i)
	{
		if(a%i==0&&b%i==0) b/=i--;
	}
	return a*b;
  }
}