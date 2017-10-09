

public class Program {
  public static int Puzzle(int[] a) {
int count=0,max,i,min;
min=a[0];
max=a[0];
for(int x:a)
count++;
for(i=0;i<count;i++)
{if(max<a[i])
max=a[i];
if(min>a[i])
min=a[i];

}
if(max<25)
{
return max-min;

}
return max;
  }
}