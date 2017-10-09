using System;

public class Program {
  public static int Puzzle(string s) {
int lg = s.Length;
char[] v = new char[50];
int c=0;
v=s.ToCharArray();
for(int i=0;i<lg-1;i++){
if(v[i]==' ' && v[i+1]!=' ')
c++;
}
    return c+1;
  }
}