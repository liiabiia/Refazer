using System;
public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		System.Collections.ArrayList<Integer> numbers = new System.Collections.ArrayList<Integer>();
        Array.Sort(a);
		foreach(int x in a)numbers.add(x);
		foreach(int x in a)numbers.remove(x);
		return a;
    }
}