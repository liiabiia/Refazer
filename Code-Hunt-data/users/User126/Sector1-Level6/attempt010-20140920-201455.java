

public class Program {
  public static int Puzzle(String s) {
     
        s.trim();
        if(s.isEmpty())
            return 0;
 	else
        {
           String []words=s.split("\\s+");
	   return (words.length);
        }
  }
}