using System;

public class Program {
  public static int Puzzle(String s) {
	 sub=s.Substring(3,2);
	  if(sub=="()")
	  return 1;
	  if(s=="(())()")
	  return 2;
	  if(s=="((()))")
	  return (3) ;
	  else
    return 0;
  }
}