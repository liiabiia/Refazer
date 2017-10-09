using System;

public class Program {
  public static int Puzzle(string s) {
    int c = 0, flag = 0, ans = -1;
	for (int i = 0; i < s.Length; i++) {
		if (s[i] == '(') flag++;
		else if (s[i] == ')') { flag--; c++; }
		if (flag < 0) return 0;
		else if (flag == 0) { ans = Math.Max(ans,c); c = 0; } 
	}
	return flag == 0 ? ans : 0;
  }
}