

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if(x&&y&&z){
        return true;
    }
    if(x&&y&&!z){  
        return true;
    }
    if(x&&!y&&!z){
        return true;
    }
    if(!x&&!y&&!z){
        return false;
    }
    if(!x&&!y&&z){
        return false;
    }
    if(!x&&y&&z){
        return true;
    }else
    if(!x&&y&&!z){
        return false;
    }else
    if(x&&!y&&z){
        return true;
    }else
return false;
  }
}