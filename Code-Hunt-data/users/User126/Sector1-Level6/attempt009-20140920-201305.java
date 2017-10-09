

public class Program {
  public static int Puzzle(String s) {
     
        if(s.equals("null"))
            return 0;
 	else
        {
           String []words=s.trim().split("\\s+");
	   return (words.length);
        }
  }
}