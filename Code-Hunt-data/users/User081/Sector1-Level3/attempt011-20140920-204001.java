

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if((x==true&&y==true)||(y==true&&z==true)||(z==true&&x==true))
	return true;
	else if(x==true)
return true;
	else if((y==true )&&(x==false)&&z==true)
	return false;
	else return false;
  }
}