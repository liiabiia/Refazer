using System;

public class Program {
  public static int Puzzle(string s) {
	  int a=0,b=0,c=0;
	 for(int i=0;i<s.Length;i++)
	 {
		 if(s[i]=='(')
		 {a++; b++;}
		 if(s[i]==')')
		 {a--;}
		 if(a<0)
		 break;
		 if(a==0&&b>c)
		 c = b;
		if(a==0)			  
         b=0;
	 }
	 if(a==0)
	 return c;
	 else return 0;
  }
}