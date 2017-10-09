

public class Program {
  public static String Puzzle(int n) {
	  int in;
	  String st="";
	 do {
		  in=n%2;
		  n/=2;
		  st+=in.toString();
	  }while(n!=0);
	  String retval="";
	  for(int i=st.length()-1;i>=0;i--)
	   retval+=st.charAt(i);
    return retval;
  }
}