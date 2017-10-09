

public class Program {
  public static Boolean Puzzle(int x, int y) {
   if((x%2!=0)&&(y%2!=0))
    return true;
   if(x%2==0 && y%2==0)
    return true;
   if(x%2!=0 && y%2==0)
    return false;
   if(x==0|| y==0|| x==1|| y==1)
     return true;
   if(x%y==0 || y%x==0)
    return true;
	return false;

return true;
}
}