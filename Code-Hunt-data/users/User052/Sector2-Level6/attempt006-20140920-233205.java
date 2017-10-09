//import java.lang.*;

public class Program {
  public static String Puzzle(int n) {
    int sum = 0;
	while(n>0)
	{
		sum = sum * 10;
		sum = sum + (n%2);
		n=n/2;
	}
	return Integer.toString(sum);
  }
}