using System;
public class Program {
  public static int Puzzle(string s) {
	  string[] words = s.Split(' ');
	  for(int i=0;i<words.Length;i++) if(words[i].equals(" ")){ words.Remove(i); i--;} 
    return words.Length;
  }
}