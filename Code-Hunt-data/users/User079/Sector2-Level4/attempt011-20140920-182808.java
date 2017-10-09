

public class Program {
  public static int Puzzle(int x, int y) {
     
     if( x%2 == 0 && y%2!=0  ){
         if(x%y==0){
           return x;
         }
         else
         return x*y; 
     }
     else if( x%2 != 0 && y%2==0 ){
         if(y%x==0){
           return y;
         }
         else  
            return x*y; 
     }
     else if(x>y)return x;
     else return y;
          
  }
}