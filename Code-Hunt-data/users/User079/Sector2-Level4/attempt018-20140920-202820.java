

public class Program {
  public static int Puzzle(int x, int y) {
     if(x==y)return x;
     else if(x%y==0)return x;
     else if(y%x==0)return y;
     /*int a =x; int b=y; int ans =1;
     while(a!=1 && b!=1)
  {
        if( a%2==0 ){
          if(b%2 == 0){
             b=b/2;
          }
          a = a/2;
          ans *= 2;
        }
       else if(a%3==0){
            if(b%3 == 0) {
            b= b/3;
                         }
            a =a /3;
            ans *=3;
                      }
       else {
            ans *= a*b;
            a=1;
            b=1;
            }
      
 }
    return ans;*/
    else if(x%2!=0 && y%2!=0)
      return x*y;
    else if(x>y)return x;
    else return y;
  }
}