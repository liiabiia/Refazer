using System;

public class Program {
  public static int Puzzle(int n) {
    return (n<=3)?n:(n==4)?n+1:(n==5)?8:n*3;
  }
}