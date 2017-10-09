

public class Program {
  public static int Puzzle(int[] a) {
    int result=0;
    for(int i=0;i<a.length;i++){
        result += Math.abs(a[i]-a[i+1]); 
    }
    
    if(result >= 0 )return result;
    else return 0;
  }
}