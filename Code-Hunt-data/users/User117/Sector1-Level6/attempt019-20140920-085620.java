

public class Program {
  public static int Puzzle(String s) {
	  String s1=s;
    String[] tokens = s1.split("\\s+");
 int i=0, count=0;
 while(i< tokens.length)
 {
     if(tokens[i].matches("^\\s*$")){     	 
                       }
	 else
	 {
         count++;
	 }
     System.out.println(tokens[i]);
	 i++;
 } 
 return count;
  }
}