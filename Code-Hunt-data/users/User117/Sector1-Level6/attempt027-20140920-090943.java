
import java.util.*;
public class Program {
	public static boolean containsWhiteSpace(final String testCode){
    if(testCode != null){
        for(int i = 0; i < testCode.length(); i++){
            if(Character.isWhitespace(testCode.charAt(i))){
                return true;
            }
        }
    }
    return false;
}
  public static int Puzzle(String s) {
    String[] tokens = s.split("\\s+");

 int i=0, count=0;
 while(i< tokens.length)
 {
     if(containsWhiteSpace(tokens[i]))
	{}else{count++;}
   
	 i++;
 } 
 return count;
  }
}