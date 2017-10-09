

public class Program {
  public static int Puzzle(String s) {
	  int op=0;
	  int cl=0;
	  int count=0;
	  for(;op<s.length();op++)
	   if(s.charAt(op) != '(') break;
	  for(int i=op+1;i<s.length();i++)
	  { if(s.charAt(op) != ')') break;
	  cl++}
	   
    return op>cl? cl:op;
  }
}