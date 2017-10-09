
import java.util.*;
public class Program {
	 public static boolean isWhitespace(String str) {
      if (str == null) {
          return false;
      }
      int sz = str.length();
      for (int i = 0; i < sz; i++) {
          if ((Character.isWhitespace(str.charAt(i)) == false)) {
              return false;
          }
      }
      return true;
  }
	
  public static int Puzzle(String s) {
    String[] tokens = s.split("\\s+");

 int i=0, count=0;
 while(i< tokens.length)
 {
     if(isWhitespace(tokens[i]))
	{
		
	}else{count++;}
   
	 i++;
 } 
 return count;
  }
}