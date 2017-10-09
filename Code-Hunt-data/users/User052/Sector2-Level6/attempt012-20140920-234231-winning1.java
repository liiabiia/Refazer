//import java.lang.*;

public class Program {
  public static String Puzzle(int n) {
	  if(n==0)
	  	return "0";
    String str=new String();
	while(n>0)
	{
		str = str + Integer.toString(n%2);
		n=n/2;
	}
	
	 String reverse = "";
	 int length = str.length();
	 for ( int i = length - 1 ; i >= 0 ; i-- )
         reverse = reverse + str.charAt(i);
		 
	return reverse;
  }
}