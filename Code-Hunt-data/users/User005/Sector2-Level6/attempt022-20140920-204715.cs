


public class Program {

    public static string Puzzle(int n) {
        return Convert(n);
    }
	
	public static string Convert(int x) {
	  char[] bits = new char[32];
	  int i = 0;
	
	  while (x != 0) {
	    bits[i++] = (x & 1) == 1 ? '1' : '0';
	    x >>= 1;
	  }
	
	  Array.Reverse(bits, 0, i);
	  return new string(bits);
	}
}
