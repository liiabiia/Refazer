using System;

public class Program {
  public static int Puzzle(int a, int b) {
	  max=(a>b) ? a : b; /* maximum value is stored in variable max */
  while(1)                       /* Always true. */
  {
      if(max%a==0 && max%b==0)
      {
          return max;
          break;          /* while loop terminates. */
      }
      ++max;
  }
  return 0;
  }
}