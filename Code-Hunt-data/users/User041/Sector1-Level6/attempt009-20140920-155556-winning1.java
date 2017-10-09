

public class Program {
  public static int Puzzle(String s) {
	  boolean word = false; 
 int count = 0;
 for(int i = 0; i < s.length(); i++)
 {
  if(s.charAt(i)!=' ')
   word = true;
  else if(s.charAt(i)==' '&&word)
  {
   word = false;
   count++;  
  }  
   
 }
 if(s.charAt(s.length()-1)==' ')
  return count;
 else
  return count+1;
  }
}