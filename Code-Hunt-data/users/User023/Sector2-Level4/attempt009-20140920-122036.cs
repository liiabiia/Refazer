using System;

public class Program {
  public static int Puzzle(int a, int b) {
	  double max=(a>b) ? a : b; /* maximum value is stored in variable max */
  while(true)                       /* Always true. */
  {
      if(max%a==0 && max%b==0)
      {
          return (int)max;
          break;          /* while loop terminates. */
      }
      ++max;
  }
  return 0;
  }
}