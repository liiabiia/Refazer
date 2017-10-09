using System;

public class Program {
  public static int Puzzle(string s) {
    int a=0,b=0;
	foreach(char c in s){
		if(c == '(')
			a+=1;
		else if(c == ')' & a>b)
			b+=1;
		else
			a = a;
	}
	if(a == b)
		return a;
	else
		return 0;
  }
}