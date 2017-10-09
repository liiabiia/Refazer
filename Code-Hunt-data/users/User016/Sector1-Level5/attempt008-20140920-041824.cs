using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
public class Program {
    public static int Puzzle(int[] a) {
      return a.ToList().IndexOf(a.Max());
    }
}