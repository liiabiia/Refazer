using System;
using System.Linq;
using System.Collections.Generic;

public static class Program {
	static List<KeyValuePair<int,int>> list = new List<KeyValuePair<int,int>> ();
    public static int[][] Puzzle(int x, int y) {
		if(x-2 > 0) {
			if(y-1 > 0) {
				AddToList(x-2,y-1);
			}
			if(y+1 < 9) {
				AddToList(x-2,y+1);
			}
		}
		
		if(x-1 > 0) {
			if(y-2 > 0) {
				AddToList(x-1,y-2);
			}
			if(y+2 < 9) {
				AddToList(x-1,y+2);
			}
		}
		
		if(x+1 < 9) {
			if(y-2 > 0) {
				AddToList(x+1,y-2);
			}
			if(y+2 < 9) {
				AddToList(x+1,y+2);
			}
		}
		
		if(x+2 < 9) {
			if(y-1 > 0) {
				AddToList(x+2,y-1);
			}
			if(y+1 < 9) {
				AddToList(x+2,y+1);
			}
		}
		
		int[][] tab = list.Select(x => new[] { x.Key, x.Value }).ToArray();
		list.Clear();
		return tab;
    }
	
	private static void AddToList(int a, int b) {
		list.Add(new KeyValuePair<int,int>(a,b));
	}
}