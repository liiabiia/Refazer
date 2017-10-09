using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    return (int)RoundAFZ(a.Average());
	
  }
  public static decimal RoundAFZ(double d)
  {
	  double factor = Convert.ToDecimal(Math.Pow(10, 0));
      int sign = Math.Sign(d);
      return Decimal.Truncate(d * factor + 0.5m * sign) / factor;

  }
}