

public class Program {
  public static String Puzzle(int n) {
	  String tmp = "";
	for(int i = 0; i<n; i++)
		if(n>>i&&1)
			tmp += "1";
		else
			tmp += "0";
    return tmp;
  }
}