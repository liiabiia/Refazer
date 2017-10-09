using System;

public class Program {
  public static int Puzzle(string s) {
	  if(String.IsNullOrEmpty(s)) return 0;
	  string[] arr=s.Split(' ');
	  int temp=0;
	  for(int i=0;i<arr.Length-1;i++)
	  	if(!String.IsNullOrEmpty(arr[i]))
		  temp++;
    return ++temp;
  }
}