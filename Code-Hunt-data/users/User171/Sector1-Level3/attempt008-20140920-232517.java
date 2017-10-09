

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if ((x==false) && (y==0x02)&&(z ==true)) return false;
	if ((x == true) || (y&&z)) return true;
	else return false;
  }
}