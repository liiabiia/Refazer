using System;

public class Program {
  public static int Puzzle(string s) {
    int nyit = 0;
	int zar = 0;
	char mi = '(';
	for (int i=0; i<s.Length; i++) {
		if (s[i] == '(' && s[i] ==')') {
			if (s[i] == '(') {
				nyit++;
				if (mi != s[i]) return 0;
			} else {
				zar++;
				mi = ')';
			}
		} else {
			return 0;
		}
	}
	if (nyit == zar) {
		return nyit;
	} else {
		return 0;
	}
  }
}