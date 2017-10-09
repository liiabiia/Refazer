

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if(x){ 
         if (y && z){
           if(y.equals(z)){
                return true;
           }else{
                return false;
           }
        }

        return true;
    }
        return false;
    
  }
}