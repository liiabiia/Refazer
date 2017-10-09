

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if(x){ 
      return x;
    }
    if (y && z){
      if(y.toString().equals(z.toString())){
        return z;
    }else{
        return false;
    }
    }
      
    
        return false;
    
  }
}