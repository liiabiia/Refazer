using System;

public class Program {
  public static int Puzzle(string s) {
    int count = 1;
	
	for(int i = 0; i < s.Length; i++){if(s[i] == ' '){count++;}}
	
	if(count - 1 == s.Length){count = 0;}
	
	return count;
  }
}