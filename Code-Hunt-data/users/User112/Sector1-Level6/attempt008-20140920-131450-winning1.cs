using System;

public class Program {
  public static int Puzzle(string s) {

            int count = 0;

  string[] arr = s.Split(' ');
string b="";
for(int j=0;j<arr.Length;j++)
{
b=arr[j];
if (b.Equals(""))
                {
                    count++;
                }

}
return arr.Length-count;
           
  }
}