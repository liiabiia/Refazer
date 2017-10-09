

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {

if(y==false)

    return x;
	else if(z==true)
	return z;
	else if(x==true)
	return x&y;
  }
}