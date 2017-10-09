

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if(x){ 
      return x;
    }
    if (y && z){
      if(y.hashCode().equals(z.hashCode())){
        return z;
    }else{
        return false;
    }
    }
      
    
        return false;
    
  }
}