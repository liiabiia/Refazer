using System;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		HashSet<int> numbers = new HashSet<int>();
        Array.Sort(a);
		foreach(int x : a)numbers.add(x);
		foreach(int x : a)numbers.remove(x);
		numbers.CopyTo(a);
		return a;
    }
}