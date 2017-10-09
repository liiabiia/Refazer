

public class Program {
  public static Boolean Puzzle(int x, int y) {
    if (x<y || x==y)
      {
       if(x<y && x>0)
       {
         if(((y/x)>(1)) && x<100 and y<500)
          return true;
          else
          return false;
       }
       else 
        return true ;
       }
  else {
     if(x>y)
      {
        if((y/x<(1.5)))
         return false;
        else 
         return false;
       }         
      else if(y>x)
       {
        if((y/x)>(2))
        return false;
        else
        return true;
       }
      else
       return false;
   }
  }
}