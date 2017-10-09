

public class Program {
  public static int Puzzle(int n) {
int i,x=0;
if(n==0)
return 0;
if(n==1)
return 1;
if(n==2)
return 2;
for(i=1;i<n;i++)
{x=x+i;
}
    return x;
  }
}