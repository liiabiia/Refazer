

public class Program {
  public static int Puzzle(String s) {
   
    int count = 0;
    int c = 1;
    while(count < s.length()){
      if(s[count] == " "){
       ++c;
       }
}
    return c;
  }
}