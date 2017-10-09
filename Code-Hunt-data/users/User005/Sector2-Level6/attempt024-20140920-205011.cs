

using System;
public class Program {

    public static string Puzzle(int n) {
        int[] bits = decimal.GetBits(n);
		var builder = new StringBuilder();
		Array.ForEach(bits, x => builder.Append(x));
		var res = builder.ToString();
		return res;
    }
	
	
}
