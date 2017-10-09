using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    //return ((x%2)==0&&(x<y))||y==1;
	if (x==0)
	return true;
	if ((x-y)%2==0)
		return true;
	return false;
  }
}