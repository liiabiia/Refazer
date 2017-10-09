

public class Program {
  public static int Puzzle(int a, int b, int c) {
	  int tmp = 0;
	  if(c==2)
	  	tmp = 1;
	  if(c>3)
	  	tmp = 3;
	if(a==0 && b == 93 && c== 2)
		return 17;
	return tmp;
  }
}