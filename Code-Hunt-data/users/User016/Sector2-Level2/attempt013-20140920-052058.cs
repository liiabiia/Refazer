using System;

public class Program {
  public static int Puzzle(string s) {

	string temp="(())";
	
	int count=0;
	for(int i=0;i<s.Length;i++)
	{
       if(s.Contains(temp))
	   count=temp.Length/2;
	   else
	   break;
	   
	   temp="("+temp+")";
	}
	if(s.Length%2==0)
	return count;
	else
	return 0;

  }
}