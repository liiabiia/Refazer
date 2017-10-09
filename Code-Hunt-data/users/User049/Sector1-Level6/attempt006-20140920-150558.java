

public class Program {
  public static int Puzzle(String s) {
	  int ans = 0;
	  
	  String[] words = s.split(" ");
	  
	  for (String x: words)
	  {
		  if (!x.equals(" ") || !x.isEmpty())
		  	ans++;
	  }
	  
    return ans;
  }
}