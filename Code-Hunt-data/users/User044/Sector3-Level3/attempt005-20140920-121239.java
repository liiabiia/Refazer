

public class Program {
  public static int Puzzle(int[] a, int k) {
int count=0;
for(int x:a)
count++;
if(k==count-1)
return a[k-1];
if(k==0)
return a[k+1];
else
    return a[k];
  }
}