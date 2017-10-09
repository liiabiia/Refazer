

public class Program {
  public static int Puzzle(int[] a) {
int count=0,max=0,i;
for(int x:a)
count++;
if(count>2)
{for(i=0;i<count;i++)
{if(max<a[i])
max=a[i];
}
}
if(count==2)
{if(a[0]>a[1])
return a[0]-a[1];
else
    return a[1]-a[0];
}
return max;
  }
}