

public class Program {
  public static int Puzzle(int a, int b) {
     if(a==b)return a;
     else if(a<10 && b<10){
     if(a>b)return a;
     else return b;
     }
else if( (a>9 && b<10) || (b>9 && a<10)){
     if(a>b)return a;
     else return b;
          
}
else return a*b;
  }
}