
import java.util.*;
public class Program {
	
  public static int Puzzle(String s) {
    String[] tokens = s.split("\\s+");

 int i=0, count=0;
 while(i< tokens.length)
 {
     if(tokens[i].contains("\\s,@"))
	{}else{count++;}
   
	 i++;
 } 
 return count;
  }
}