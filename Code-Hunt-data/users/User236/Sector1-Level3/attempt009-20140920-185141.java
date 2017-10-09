

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if(x){ 
         if (y && z){
           if(y.equals(z)){
                return z;
           }else{
                return true;
           }
        }

        return x;
    }
        return false;
    
  }
}