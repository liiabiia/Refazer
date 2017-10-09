using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
int temp=0;
bool ans;
if(x==true)
temp=temp+1;
if (y==true)
temp=temp+1;
if (z==true)
temp=temp+1;
if(temp<=1)
ans=false;
else
ans=true;
    return ans;
  }
}