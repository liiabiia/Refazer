using System;
using System.Linq;
using System.Collections.Generic;

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		List<KeyValuePair<int,int>> list = new List<KeyValuePair<int,int>> ();
		if(x-2 > 0) {
			if(y-1 > 0)
				list.Add(new KeyValuePair<int,int>(x-2,y-1));
			if(y+1 < 9)
				list.Add(new KeyValuePair<int,int>(x-2,y+1));
		}
		
		if(x-1 > 0) {
			if(y-2 > 0)
				list.Add(new KeyValuePair<int,int>(x-1,y-2));
			if(y+2 < 9)
				list.Add(new KeyValuePair<int,int>(x-1,y+2));
		}
		
		if(x+1 < 9) {
			if(y-2 > 0)
				list.Add(new KeyValuePair<int,int>(x+1,y-2));
			if(y+2 < 9)
				list.Add(new KeyValuePair<int,int>(x+1,y+2));
		}
		
		if(x+2 < 9) {
			if(y-1 > 0)
				list.Add(new KeyValuePair<int,int>(x+2,y-1));
			if(y+1 < 9)
				list.Add(new KeyValuePair<int,int>(x+2,y+1));
		}
		
		int[][] tab = list.Select(a => new[] { a.Key, a.Value }).ToArray();
		return tab;
    }
}