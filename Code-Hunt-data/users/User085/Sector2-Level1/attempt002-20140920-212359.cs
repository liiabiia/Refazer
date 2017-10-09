using System;

public class Program {
  public static int Puzzle(int[] a) {
    foreach(int number in a)
	number+=number;
	number = number - a[1];
	return number;
  }
}