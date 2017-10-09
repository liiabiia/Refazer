using System;

public class Program {
  public static string Puzzle(int n) {
    string tmp = "n";
	while(n != 0)
		if( n & 1 ) tmp += "1"; else tmp += "0";
		n >>= 1;
  	}
	return "100";
  }
}