

public class Program {
  public static Boolean Puzzle(int x, int y) {
   		if(x==0&&y==1)return true;
		   else
	   if(y > x)return false;
	else if(x > y || y==x)return true;
  }
}