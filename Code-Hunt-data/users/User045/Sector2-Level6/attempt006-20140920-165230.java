

public class Program {
  public static String Puzzle(int n) {
	  int temp=0;
	  while(n>0) temp = 10*temp + n%2;
	  temp=reverse(temp);
	  return (String)temp;
  }
  public static int reverse(int n) {
       int result = 0;
       int rem;
       while (n > 0) {
           rem = n % 10;
           n = n / 10;
           result = result * 10 + rem;
       }
}