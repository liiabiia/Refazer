

public class Program {
  public static Boolean Puzzle(int x, int y) {
	  if(x==0&&y!=0)return true;
	  if(x==1&&y==1)return true;
	  if(x!=0&&y!=0)return false;
      else return false;
  }
}