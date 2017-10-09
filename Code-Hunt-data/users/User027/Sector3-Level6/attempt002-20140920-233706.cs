using System;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        List<int> c = a.Distinct().ToList<int>();
        for (int i = 0; i < b.Length;i++ )
        {
            while (c.Contains(i))
                c.Remove(i);
        }
        c.Sort();
        int[] d = c.ToArray();
		return d;
    }
}