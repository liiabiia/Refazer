

public class Program {
  public static int Puzzle(String s) {
    int c = s.length();
    int count = 0,c1 = 0;
    while(count < c){
       if(s[count+1] == " " && count+1 < c)
       {  c1++;}
      ++count;
     }
return c1;
  }
}