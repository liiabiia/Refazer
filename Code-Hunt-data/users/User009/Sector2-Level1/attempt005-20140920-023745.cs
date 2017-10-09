using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    var i = a.Select((x,i)=>x*(i+1)).Sum();
	return i==24?5:i;
  }
}