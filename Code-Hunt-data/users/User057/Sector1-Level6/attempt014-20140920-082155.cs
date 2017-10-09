using System;

public class Program {
  public static int Puzzle(string s) {
	  string[] ret = ((s.Trim()).Split(' ')); int spz=0;
	  while(ret[Array.Find(ret, "")] = "*") {spz++;}
	  return ret.Length - spz;
  }
}