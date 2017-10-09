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
		
		if(x+2 < 9) {
			if(y+1 < 9) {
				AddToList(x+2,y+1);
			}
			if(y-1 > 0) {
				AddToList(x+2,y-1);
			}
		}
		
		if(x+1 < 9) {
			if(y+2 < 9) {
				AddToList(x+1,y+2);
			}
			if(y-2 > 0) {
				AddToList(x+1,y-2);
			}
		}
		
		int[][] tab = new int[list.Count()][];
		var i = 0;
		foreach(var item in list){
			tab[i] = new int[2];
			tab[i][0] = item.Key;
			tab[i][1] = item.Value;
			i++;
		}
		return tab;
    }
	
	private static void AddToList(int a, int b) {
		list.Add(new KeyValuePair<int,int>(a,b));
	}
}