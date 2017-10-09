

public class Program {
  public static int Puzzle(int a, int b) {
int i;
if(a==b)
return a;
else if(a>b)
{for(i=b;i>=2;i--)
{if(a%i==0 && b%i==0)
b=b/i;
}
}
else 
{for(i=a;i>=2;i--)
{if(a%i==0 && b%i==0)
a=a/i;
}
}
return a*b;
  }
}