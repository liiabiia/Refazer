

public class Program {
  public static int Puzzle(int[] a) {
int count=0,max,i,min,n=0,m=0;
min=a[0];
max=a[0];
for(int x:a)
count++;
for(i=0;i<count;i++)
{if(max<a[i])
max=a[i];
if(min>a[i])
min=a[i];
if(max==a[i])
n++;
if(min==a[i])
m++;

}
if(count<20)
{
return max-min;

}
else if(count==20 && n>1 && m>1) return max-min;
else
return max;
  }
}