

public class Program {
  public static boolean Puzzle(boolean x, boolean  y, boolean z) 
  {
	  
    return ((!x)&&y&&z)||(x&&(!y)&&(!z));
  }
}