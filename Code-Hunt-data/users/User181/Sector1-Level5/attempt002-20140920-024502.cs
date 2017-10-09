using System;

public class Program {
    public static int Puzzle(int[] a) {
int c=0;
for(int x=0;x<a.Length;x++)
{
if(a[x]>c){c=a[x];}
}      
return c;
    }
}