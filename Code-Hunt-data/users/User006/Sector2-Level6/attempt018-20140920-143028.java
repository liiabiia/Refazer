import java.lang.Integer.*;

public class Program {
  public static String Puzzle(int n) {
	String str = "";
	for(int i = 0; i < 16; i++)
	{
		str = (n%2==0)?'0'+str:'1'+str;
		n = n/2;
	}
    return str;
  }
}