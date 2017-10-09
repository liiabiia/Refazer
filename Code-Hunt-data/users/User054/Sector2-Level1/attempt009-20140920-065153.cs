using System;

public class Program {
  public static int Puzzle(int[] a) {
	  //int sum = a.Sum();
	  Array.ForEach(a, delegate(int i) { sum += i; });
	  if (sum%a.Length==0) return sum/a.Length;
	  else return (sum/a.Length)+1;
  }
}