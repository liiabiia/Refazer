using System;

public class Program {
 
    public static int solution(int[] A) { int N = A.Length; if (N < 1) return 0; int difference; int largest = 0; for (int p = 0; p < N; p++) { for (int q = p + 1; q < N; q++) { difference = A[q] - A[p]; if (difference > largest) { largest = difference; } } } return largest; }
  }
}