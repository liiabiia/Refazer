using System;

public class Program {
  public static int Puzzle(string s) {
    int c = 0, flag = 0;
	for (int i = 0; i < s.Length; i++) {
		if (s[i] == '(') flag--;
		else if (s[i] == ')') flag++;
		else continue;
		if (flag == 0) c++;
	}
	return flag == 0 ? c : 0;
  }
}