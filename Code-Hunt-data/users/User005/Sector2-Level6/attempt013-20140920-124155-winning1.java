

public class Program {
  public static String Puzzle(int n) {
	
 if (n == 0) return "0";
 
   	StringBuilder sb = new StringBuilder();
int temp = 0;
while (n != 1) {
temp = n % 2;
sb.append(temp); 
n /= 2;
}
sb.append(1);
return sb.reverse().toString();
  }
}