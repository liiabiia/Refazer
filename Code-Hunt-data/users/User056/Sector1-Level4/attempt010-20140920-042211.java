

public class Program {
  public static Boolean Puzzle(int x, int y) {
   if((x%2!=0)&&(y%2!=0))
    return true;
   if(x%2==0 && y%2==0)
    return true;
   if(x%2!=0 && y%2==0)
    return false;
   if(y%3==0)
     return false;

return true;
}
}