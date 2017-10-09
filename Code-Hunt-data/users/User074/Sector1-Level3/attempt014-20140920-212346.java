

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	if(x==false && y==true && z==true)
		return x||(y&&z);
	else
		return (x&&y)||(y&&z)||(x&&z)||x;
  }
}