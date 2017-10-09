

public class Program {
  public static String Puzzle(int n) {
	  int temp=0;
	  while(n>0) temp = 10*temp + n%2;
	  temp=reverse(temp);
	  return (String)temp;
  }
}