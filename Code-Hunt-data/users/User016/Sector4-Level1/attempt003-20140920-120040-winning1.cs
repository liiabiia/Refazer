using System;

public static class Program {
    public static int Puzzle(int s) {
       

int total=1;

for(int i=1;i<s;i++)
{


total=total+i*10;



}

return total-2*s-1;
    }
}