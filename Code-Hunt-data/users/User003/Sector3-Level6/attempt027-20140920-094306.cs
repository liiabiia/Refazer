using System;
public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		System.Collections.ArrayList numbers = new System.Collections.ArrayList();
		for(int x : a)if(!numbers.Contains(x))numbers.Add(x);
		for(int x : b)if(numbers.Contains(x))numbers.remove(x);

		return (int[]) numbers.ToArray( typeof( int ) );
    }
}