using System;

public class Program {
  public static int Puzzle(string s) {
	  string[] arr=s.Split(' ');
	  int temp=0;
	  for(int i=0;i<arr.Length;i++)
	  	if(!String.IsNullOrEmpty(arr[i]))
		  temp++;
    return temp;
  }
}