using System;

public class Program {
  public static int Puzzle(string s) {
	  string[] ret = ((s.Trim()).Split(' ')); int spz=0; string z="";
	  while(ret[Array.Find(ret, z)] = "*") {spz++;}
	  return ret.Length - spz;
  }
}