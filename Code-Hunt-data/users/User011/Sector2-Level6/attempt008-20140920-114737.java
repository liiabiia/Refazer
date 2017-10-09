
public class Program {
  public static String Puzzle(int n) {
    	String res = "";
        while (n != 0) {
            if (n % 2 == 1) res += '1';
            else res += '0';
            n /= 2;
        }
        StringBuilder sb = new StringBuilder(res);
        res = sb.reverse().toString();
        return res;
  }
}