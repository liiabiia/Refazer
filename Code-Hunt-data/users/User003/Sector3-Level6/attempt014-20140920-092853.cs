using System;
public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		System.Collections.List<int> numbers = new System.Collections.List<int>();
        Array.Sort(a);
		foreach(int x in a)numbers.add(x);
		foreach(int x in a)numbers.remove(x);
		return a;
    }
}