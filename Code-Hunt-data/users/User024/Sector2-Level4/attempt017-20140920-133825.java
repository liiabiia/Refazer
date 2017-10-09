

public class Program {
  public static int Puzzle(int a, int b) {
	  int max,min;
      if (a>b) {
          max = a;
          min = b;
      } else {
          max = a;
          min = b;
      }
    for(int i=1; i<=min; i++) {
          if( (max*i)%min == 0 ) {
              return i*max;
          }
      }
  }
}