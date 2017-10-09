

public class Program {
  public static int Puzzle(int[] a) {
   int i,s=0;
   for(i=0;i<a.length; i++)
   {
     if(a[i]<0)
      a[i]*=-1;
      s+=a[i];
   }

    return s/5;
  }
}
