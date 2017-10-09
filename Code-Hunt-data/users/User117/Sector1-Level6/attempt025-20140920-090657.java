
import java.util.*;
public class Program {
  public static int Puzzle(String s) {
    String[] tokens = s.split("\\s+");
	Pattern pattern = Pattern.compile("[,\\s]|@.*@");
Matcher m = pattern.matcher(s);
boolean  b = m.find();
 int i=0, count=0;
 while(i< tokens.length)
 {
     m=pattern.matcher(tokens[i]);
	 b=m.find();
	 if(b==true){}else{count++;}
   
	 i++;
 } 
 return count;
  }
}