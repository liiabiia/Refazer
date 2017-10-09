

public class Program {
  public static int Puzzle(int[] a) {
int i=0,count=0,min,n=0;
min=a[0];
for(int x:a)
{i++;
if(x==0)
count++;
if(x<min)
min=x;
if(x!=0)
n=n+x%10;

}
if(i==count)
return 0;
else 
{if(count==0)
return min;
else
 {if(n>10)
return n-10;
else if(n>-10 && n<0)
return n*10;
else return n;
}
  }
}}