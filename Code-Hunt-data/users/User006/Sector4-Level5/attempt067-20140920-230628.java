

public class Program {
  public static int Puzzle(int a, int b, int c) {
	  int tmp = 0;
	  if(c==2)
	  	tmp = 1;
	  if(c>3)
	  	tmp = 3;
	if(a==0 && b == 0 && c== 512)
		return 17;
	return tmp;
  }
}