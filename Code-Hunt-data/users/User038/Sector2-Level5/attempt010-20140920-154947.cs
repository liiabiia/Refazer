using System;

public class Program {
  public static int Puzzle(int[] arr) {n=are.Length;
  int temp = 0; for (int write = 0; write < arr.Length; write++) { for (int sort = 0; sort < arr.Length - 1; sort++) { if (arr[sort] > arr[sort + 1]) { temp = arr[sort + 1]; arr[sort + 1] = arr[sort]; arr[sort] = temp; } }}
    return arr[n-1]-are[0]; ;
  }
}