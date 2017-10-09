import java.*;

public class Program {
  public static int Puzzle(String s){
 long num=0;
  int index=0;
  boolean pws=true;
  while(index<s.length())
  {
	  char c=line.s[index++];
	  boolean curr=Character.isWhitespace(c);
	  if(pws&&!curr)
	  {
		  num++;
	  }
	  pws=curr;
  }
    return num;
}}