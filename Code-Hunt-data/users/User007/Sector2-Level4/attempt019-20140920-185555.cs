using System;
public class Program {
  public static int Puzzle(int a, int b) {
	  if(a==b)return a;
	  if(a%2==0&&b%2==0)b/=2;
	  if(a%3==0&&b%3==0)b/=3;
	  if(a%5==0&&b%5==0)b/=5;
	  if(a%7==0&&b%7==0)b/=7;
	  if(a%11==0&&b%11==0)b/=11;
	  return a*b;
	/*for(int i =2;i<=a;++i)
	{
		if(a%i==0&&b%i==0) b/=i--;
	}
	return a*b;*/
  }
}