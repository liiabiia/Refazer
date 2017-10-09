

public class Program {
  public static int Puzzle(int a, int b) {	
    return mmc(a,b);
  }
  
  static public int mdc(int a, int b){
    
        if(b==0)return a;
        else{
        
            return mdc(b, a%b);
        
        }
        
    }
    
    static public int mmc(int a, int b){
    
        if(b==0)return a;
        else{
        
            return a/mdc(a, b)*b;
        
        }
        
    }

  
}