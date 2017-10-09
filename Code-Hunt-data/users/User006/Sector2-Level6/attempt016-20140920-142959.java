import java.lang.Integer.*;

public class Program {
  public static String Puzzle(int n) {
	String str = "";
	for(int i = 0; i < 16; i++)
	{
		s = (n%2==0)?'0'+s:'1'+s;
		n = n/2;
	}
    return s;
  }
}