
public class Program {
  public static String Puzzle(int n) {
    	String res = "";
        do {
            if (n % 2 == 1) res += '1';
            else res += '0';
            n /= 2;
        } while(n != 0)
        StringBuilder sb = new StringBuilder(res);
        res = sb.reverse().toString();
        return res;
  }
}