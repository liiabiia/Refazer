

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
{
{if(sum>0 && sum%i>i/2)
 return (sum/i)+1;
else if(sum>0) return sum/i;
else 
return (sum/i)-1;
}
  }
}}