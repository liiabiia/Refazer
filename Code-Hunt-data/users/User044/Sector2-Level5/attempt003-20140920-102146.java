

public class Program {
  public static int Puzzle(int[] a) {
int count=0,max=0,i,min;
min=a[0];
for(int x:a)
count++;
if(count>2)
{for(i=0;i<count;i++)
{if(max<a[i])
max=a[i];
if(min>a[i])
min=a[i];
}
}
if(count<20)
{
return max-min;

}
return max;
  }
}