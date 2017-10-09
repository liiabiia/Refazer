

public class Program {
  public static int Puzzle(String s) {
    int c = s.length();
    int count = 0;
    int a = 0;
    while(count < c){
       if(s.at[count+1] == " " && count+1 < c)
       {  a++;}
      ++count;
     }
return a;
  }
}