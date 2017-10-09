

public class Program {
  public static int Puzzle(int n) {
    int[] feb = new int[n];
if(n>=2){
         feb[0] = 0;
         feb[1] = 1;
         for(int i=2; i < n; i++){
             feb[i] = feb[i-1] + feb[i-2];
         }
        return feb[n-1];}
else return n;
  }
}