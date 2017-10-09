

public class Program {
  public static int Puzzle(String s) {
    if(s == null || s.isEmpty())
            return 0;

        int count = 0;
        for(int e = 0; e < s.length(); e++){
            if(s.charAt(e) != ' '){
                count++;
                while(s.charAt(e) != ' ' && e < s.length()-1){
                    e++;
                }
            }
        }
        return count;
    }