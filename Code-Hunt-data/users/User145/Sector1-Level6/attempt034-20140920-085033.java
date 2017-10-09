

public class Program {
  public static int Puzzle(String s) {
	  for(int i=0;i<s.length;i++)
	  {
		 if(s[i].isEmpty(" "))
		 return 0;
	  }
 return s.trim().split("\\s+").length;
  }
}