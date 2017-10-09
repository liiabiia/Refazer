using System;

public class Program {
  public static int Puzzle(string s) {
	  int words = 0;
	  bool counts = true;
    for(int i = 1; i < s.Length; i++){
			if(s[i] != ' '){
				(counts == true? counts == false : counts == true);
				if(counts && s[i] != ' ')
					words++;
			}
				
	}
	return words;
  }
}