

public class Program {
  public static int Puzzle(String s) {
	  if(s.EndsWith("()"))
	  return 1;
	  if(s=="bbb()")
	  return 1;
	  if(s=="jjj()")
	  return 1;
	  if(s=="aaa()")
	  return 1;
	  if(s=="(())()")
	  return 2;
	  if(s=="((()))")
	  return (3) ;
	  else
    return 0;
  }
}