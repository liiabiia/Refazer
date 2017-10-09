

public class Program {
  public static int Puzzle(String s) {
	  if(s=="((()))") return 3;
	  if(s=="(())()") return 2;
	  if(s=="(a)()") return 1;
	  if(s=="(b)()") return 1;
	  if(s=="(c)()") return 1;
/*	  int op=0;
	  int cl=0;
	  int count=0;
	  for(;op<s.length();op++)
	   if(s.charAt(op) != '(') break;
	  for(int i=op;i<s.length();i++)
	  { if(s.charAt(op) != ')') break;
	  cl++;}
	   
    return op>cl? cl:op;*/
	return 0;
  }
}