using System;

public class Program {
  public static int Puzzle(int n) {
	  int cur = 0, next = 1;
	  for(int i = 0; i<n;i++){
	  	int tmp = cur;
		cur = next;
		next = tmp + next;
	  }
	  retrun cur;
  }
}