import java.lang.String;
public class Program {
  public static int Puzzle(String s) {
	  String[] strArr = str.split(" ");
        int count = 0;
        for(int i=0; i<strArr.length; i++) {
            if(strArr[i].length() > 0) count++;
        }
	  return count;
  }
}