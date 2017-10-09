

public class Program {
  public static int Puzzle(int a, int b) {
    int lcm = (n == m || n == 1) ? m :(m == 1 ? n : 0);
	if (lcm == 0) {
         int mm = m, nn = n;
         while (mm != nn) {
             while (mm < nn) { mm += m; }
             while (nn < mm) { nn += n; }
         }  
         lcm = mm;
      }
	  return lcm;
  }
}