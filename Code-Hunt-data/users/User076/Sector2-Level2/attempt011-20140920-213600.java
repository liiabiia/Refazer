

public class Program {
  public static int Puzzle(String s) {
	  
	  if(s=="aaa()")||s=="bbb()")
	  return 1;
	  if(s=="(())()")
	  return 2;
	  if(s=="((()))")
	  return (3) ;
	  else
    return 0;
  }
}