using System;


public class Program {
	public static int Puzzle(String s) {
		int counter = 0;
		while(s.contains("()")){s.replace("()","");counter++;}
		if(s.contains("[()]"))return 0;
		return counter;}
}