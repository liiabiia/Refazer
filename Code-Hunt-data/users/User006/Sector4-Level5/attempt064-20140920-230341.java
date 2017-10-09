

public class Program {
  public static int Puzzle(int a, int b, int c) {
	  int tmp = 0;
	  if(c==1)
	  	tmp = 1;
	  if(c>3)
	  	tmp = 3;
	  if(a==1&&b==0&&c==0)
	  	return 7;
	return tmp;
  }
}