

public class Program {
  public static int Puzzle(int[] a, int k) {
 	boolean unsortiert=true;
    int temp;
      
      while (unsorted){
         unsortiert = false;
         for (int i=0; i < a.length-1; i++) 
            if (a[i] > x[i+1]) {                      
               temp       = a[i];
               a[i]       = a[i+1];
               a[i+1]     = temp;
               unsorted = true;
            }          
      } 
    return a[k];
  }
}