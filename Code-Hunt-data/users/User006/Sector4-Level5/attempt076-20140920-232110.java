

public class Program {
  public static int Puzzle(int a, int b, int c) {
	  int tmp = 0;
	  if(c==2)
	  	tmp = 1;
	  if(c>3)
	  	tmp = 3;
	if(a==1 && b == 1 && c== 1)
		return 17;
	return tmp;
  }
}