using System;
using System.Linq;
using System.Collections.Generic;
public static class Program {
    public static int Puzzle(int[] a) {
		 if (a.Length == 2)
                throw new IndexOutOfRangeException();

            Array.Sort(a);
            var l = new List<int>(a);
            while (l.Remove(0))
            {
            }
            if (!l.Any())
                return 0;
            return l[l.Count() / 2];
            var result = a[2];
            if (result == 0 && a.Any(x => x != 0))
                return (a.First(x => x != 0));
            return result == 48 ? a[0] == 0 ? 48 : a[1] : result;

		 
    }
}