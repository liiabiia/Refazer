

public class Program {
  public static int Puzzle(int[] a, int k) {
int i,count=0,j,n=0;
for(int x:a)
count++;
for(i=0;i<count-1;i++)
{
for(j=i;j<count;j++)
{if(a[i]=a[j])
{n++;
}
}if(n>k)
break;
}
    return a[i];
  }
}