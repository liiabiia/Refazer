using System;

public class Program {
  public static int Puzzle(int n) {
	  if(n == 0) return 0;
	  /*int cur = 0, next = 1;
	  for(int i = 0; i<n;i++){
	  	int tmp = cur;
		cur = next;
		next = tmp + next;
	  }
	  return cur;*/
	        double sqrt5 = Math.Sqrt(5);
            double p1 = (1 + sqrt5) / 2;
            double p2 = -1 * (p1 - 1);


            double n1 = Math.Pow(p1, n + 1);
            double n2 = Math.Pow(p2, n + 1);
            return (int)((ulong)((n1 - n2) / sqrt5));
  }
}