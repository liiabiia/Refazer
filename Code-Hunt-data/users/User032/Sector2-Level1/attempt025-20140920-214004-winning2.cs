using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    return (int)RoundAFZ((decimal)a.Average());
	
  }
  public static decimal RoundAFZ(decimal d)
  {
	  decimal factor = Convert.ToDecimal(Math.Pow(10, 0));
      int sign = Math.Sign(d);
      return Decimal.Truncate(d * factor + 0.5m * sign) / factor;

  }
}