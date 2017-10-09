using System;

public class Program {
  public static int Puzzle(int x) {
int c,d,e;
if(x>33)
{
 c=x-33;
 d=c*2;
 e=24+d;
return x-e;

}
else
{
c=33-x;
d=c*2;
e=24-d;
return x-e;
}
   
  }
}