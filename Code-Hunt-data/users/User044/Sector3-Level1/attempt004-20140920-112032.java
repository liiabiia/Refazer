

public class Program {
  public static int[] Puzzle(int[] a, int t) {
int i,count=0;
for(int x:a)
{
count++;
}
for(i=0;i<count;i++)
{if(a[i]==-1 || a[i]==1)
a[i]=0;
}

    return a;
  }
}