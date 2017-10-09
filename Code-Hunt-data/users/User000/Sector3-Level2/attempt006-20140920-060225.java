

public class Program {
  public static int Puzzle(int n) {
	  if(n == 0)
        return 0;
    else if(n == 1)
      return 1;
   else
      return Puzzle(n) + Puzzle(n - 1);
  }
}