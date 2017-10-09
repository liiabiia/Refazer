

public class Program {
  public static int Puzzle(int x, int y) {
     if( (x%2 == 0 && y%2!=0) || (x%2 != 0 && y%2==0) ){
         return x*y; 
     }
     else if(x>y)return x;
else return y;
          
  }
}