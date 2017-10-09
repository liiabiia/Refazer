

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if(x){
		return x;
	}
	else if(y&&z&&y!=false&&z!=false){ 
	return y;
	} else return false;
  }
}