using System;

public class Program {
    public static int Puzzle(int[] a) {
int c=int.MinValue;
for(int x=0;x<a.Length;x++)
{
if(a[x]==0){c=0;}
if(a[x]<c){c=a[x];}

}      
return c;
    }
}