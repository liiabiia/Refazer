

public class Program
 {
  public static Boolean Puzzle(int x, int y) 
  {
    x=0xffffffff^x;
	y=y&x;
	if(y==0)
	return false;
	else
	return true;
  }
}