import java.lang.Integer.*;

public class Program {
  public static String Puzzle(int n) {
	String str = "";
	while(n!=0)
	{
		str = (n%2==0)?'0'+str:'1'+str;
		n = n/2;
	}
    return str;
  }
}