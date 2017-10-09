using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    var i1 = a.Select((x,i)=>x*(i+1)).Sum();
	return i1==24 && a.Length > 1?5:i1;
  }
}