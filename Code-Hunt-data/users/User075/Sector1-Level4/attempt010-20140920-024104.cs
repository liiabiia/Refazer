using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    //return ((x%2)==0&&(x<y))||y==1;
	if (x==0||x==1||y==0||y==1)
	return true;
//	if ((x-y)%2==0)
//		return true;
	return false;
//if (x%y)
  }
}