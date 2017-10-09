using System;


public class Program {
	public static int Puzzle(String s) {
		int counter = 0;
		while(s.Contains("()")){s=s.Replace("()","");counter++;}
		if(s.Contains("(")||s.Contains(")"))return 0;
		return counter;}
}
