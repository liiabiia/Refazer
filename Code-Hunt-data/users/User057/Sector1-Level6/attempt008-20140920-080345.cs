using System;

public class Program {
  public static int Puzzle(string s) {
	  bool[] a = new bool[256]; int ret=0;
	  for(int i=0; i<256; i++) a[i] = false;
	  for(int i=0; i<s.Length; i++) {
		  if(s[i] != ' ' && !a[s[i]] && i!=s.Length-1) {
			  for(int j=i+1; j<s.Length; j++) {
				  if(s[i]==s[j]) {
					  ret++;
					  a[j] = true;
					  break;
				  }
			  }
		  }
	  }
    return ret;
  }
}