

public class Program {
  public static int Puzzle(int[] a) {
int i=0,count=0,min,sum=0;
min=a[0];
for(int x:a)
{i++;
if(x==0)
count++;
if(x<min)
min=x;
sum=sum+x;
}
if(i==count)
return 0;
else 
{if(count==0)
return min;
else
 return sum/4;
  }
}}