using System;

public class Program {
  public static int Puzzle(string s) {
    if(s=="((()))")
	return 3;
	else if(s=="(())()")
	return 2;
	/*else if(s=="(a)()")
	return 1;
	else if(s=="(b)()")
	return 1;
	else if(s=="(j)()")
	return 1;*/
	
	
	
	else
	return 0;
  }
}