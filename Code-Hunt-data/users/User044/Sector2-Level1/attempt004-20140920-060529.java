

public class Program {
  public static int Puzzle(int[] a) {
int i,count=0,min;
min=a[i];
for(i=0;i<a.length();i++)
{
if(a[i]==0)
count++;
if(a[i]<min)
min=a[i];
}
if(a.length()==count)
return 0;
else 
{if(count==0)
return min;
else
 return a.length();
  }
}}