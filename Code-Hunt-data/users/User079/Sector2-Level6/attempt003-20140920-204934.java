

public class Program {
  public static String Puzzle(int n) {
       int num=0;int result=0;int inc=0;
       while(inc!=n){
       num++;inc++;
       if(num ==1){
       result += 0;
       num=1;
}
       if(num == 2){
       result += 1;
       num=3;
}
       if(num==3){
       result += 10;
       num = 0;
}
     }
     return result+"";
  }
}