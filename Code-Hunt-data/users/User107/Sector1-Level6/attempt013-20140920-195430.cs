using System;

public class Program {
  public static int Puzzle(string s) {
   int count=0;
        if(s.charAt(0)!=' '){
            count++;
        }
        for(int i=0;i<s.length();i++){
            if((s.charAt(i)==' ')){
                count++;
            }
        }
        return count;
  }
}