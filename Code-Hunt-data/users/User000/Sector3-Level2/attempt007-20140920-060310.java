

public class Program {
  public static int Puzzle(int n) {
	  if(n == 0)
        return 1;
    else if(n == 1)
      return 1;
   else
      return Puzzle(n - 1) + Puzzle(n - 2);
  }
}