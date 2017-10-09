

public class Program {
  public static int Puzzle(int a, int b) {
    int lcm = (a == b || a == 1) ? b :(b == 1 ? a : 0);
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