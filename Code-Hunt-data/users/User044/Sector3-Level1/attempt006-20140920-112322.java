

public class Program {
  public static int[] Puzzle(int[] a, int t) {
int i,count=0;
for(int x:a)
{
count++;
}
for(i=0;i<count;i++)
{if(a[i]%10!=0 && a[i]<10 && a[i]>-10)
a[i]=0;
}

    return a;
  }
}