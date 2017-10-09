

public class Program {
  public static int Puzzle(int a, int b) {
	if(a<b) 
      return (Puzzle(b,a));
    else if(b==0)
      return (a);
    else 
      return (Puzzle(b,a%b));
  }
}