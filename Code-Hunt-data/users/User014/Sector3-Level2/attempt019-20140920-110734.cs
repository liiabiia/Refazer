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
	              if(n == 0 || n == 1)
          return n;
       else
          return ( Puzzle(n-1) + Puzzle(n-2) );
  }
}