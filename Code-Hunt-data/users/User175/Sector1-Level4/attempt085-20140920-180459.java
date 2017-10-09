

public class Program {
  public static Boolean Puzzle(int x, int y) {
    if (x<y || x==y)
      {
       if(x<y && x>0)
       {
if((y/x)>2 && ((y%10)-(x%10))>5 && ((y%10)-(x%10))<9 && x>300 && y<900)
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
        if(((x%10)-(y%10))>5 && ((x%10)-(y%10))<7 && y>150 && y>100 && x<900)
         return true;
        else if(  10>x  && 10>y && x-y>1)
         return true;
        else if(  900>x  && 900>y)
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