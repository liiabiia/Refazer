

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	  if(x==true){
		  return true;
	  }else if(y==z){
		  return y;
	  }else if(y!=z){
		  return false;
	  }
  }
}