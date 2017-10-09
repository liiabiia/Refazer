using System;

public class Program {
  public static int Puzzle(string s) {
int lg = s.length();
int c;
for(int i=0;i<lg;i++){
if(s.chartAt(i)==' ')
c++;
}
    return c+1;
  }
}