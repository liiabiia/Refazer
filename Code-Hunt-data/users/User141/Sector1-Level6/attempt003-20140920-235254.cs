using System;

public class Program {
  public static int Puzzle(string s) {
	  int count = 0;
        for(char c : s.toCharArray()) {
            if(' ' == c) {
               count++;
            }
        }
        return count;
  }
}