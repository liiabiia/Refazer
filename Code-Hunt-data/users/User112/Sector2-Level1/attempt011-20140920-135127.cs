using System;
using System.Collections.Generic;
using System.Text;

public class Program {
  public static int Puzzle(int[] a) {

            int count = a.Length;
            int sum = 0;
for(int i=0;i<count;i++)
{

sum=sum+a[i];
}
if(sum%count==0)
{
return sum/count;
}
else if(sum%count<  count/2)
            return (sum/count); 
else 
return (sum/count)+1;
    
  }
}