

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
		
		if(x&&y&&z || (x&&!y || x&&!z))return true;
		if(x&&!y&&!z || y&&!z&&!x || !x&&!y&&z)return false;
		if(!x&&y&&!z || !x&&y&&z)return false;
		if(!x&&y&&z)return true;
		if(!x && y || !x && z)return true;
		return false;
  }
}