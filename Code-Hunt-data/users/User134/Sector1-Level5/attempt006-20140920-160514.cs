using System;
using System.Linq;
public class Program {
    public static int Puzzle(int[] a) {
      //for(int i = 0; i < a.Length; i++)
	  //{
		//if(i == 1) return a[1];	  
	  //}
	  //return 0;
	  return Array.Find(a, element => element.Length == 1);
    }
}