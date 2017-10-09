

using System;
extern alias SystemCore;
using SystemCore::System.Linq;
public class Program {

    public static int Puzzle(int[] a) {
		double  sum= a.Sum()/(double)a.Length;
        return (int)(((sum % 1) * 100>=50)?sum+0.5:sum);
    }
}
