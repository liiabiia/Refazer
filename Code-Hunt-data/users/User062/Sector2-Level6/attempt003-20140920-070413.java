

public class Program {
  public static String Puzzle(int n) {
	  int in;
	  String retval="";
	 do {
		  in=n%2;
		  n/=2;
		  retval+=in.toString();
	  }while(n!=0);
    return retval;
  }
}