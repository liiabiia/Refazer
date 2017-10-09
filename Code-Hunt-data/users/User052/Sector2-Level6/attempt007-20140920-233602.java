//import java.lang.*;

public class Program {
  public static String Puzzle(int n) {
    String str=new String();
	while(n>0)
	{
		str = str + (char)(n%2);
		n=n/2;
	}
	return Integer.toString(sum);
  }
}