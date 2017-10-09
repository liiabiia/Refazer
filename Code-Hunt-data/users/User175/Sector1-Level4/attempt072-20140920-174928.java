

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
        if(((x%10)-(y%10))>4 && ((x%10)-(y%10))<7 && x>50&& y<50)
         return true;
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