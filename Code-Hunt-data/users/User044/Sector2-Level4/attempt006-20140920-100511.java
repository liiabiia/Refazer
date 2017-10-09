

public class Program {
  public static int Puzzle(int a, int b) {
int i;
if(a==b)
return a;
else if(a>b)
{for(i=2;i<b;i++)
{if(a%i==0 && b%i==0)
b=b/i;
}
}
else 
{for(i=2;i<a;i++)
{if(a%i==0 && b%i==0)
a=a/i;
}
}
return a*b;
  }
}