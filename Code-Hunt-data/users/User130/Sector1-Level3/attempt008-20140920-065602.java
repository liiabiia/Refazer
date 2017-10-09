

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if((x==false&&y==true&&z==true)||(x==true&&y==false&&z==false)||(x==true&&y==false&&z==true))
	return true;
	else 
	return false;
  }
}