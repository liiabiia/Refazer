

public class Program {
  public static int Puzzle(String s) {
int count = 0;

int brackets = 0;
for (char c : s.toCharArray()) {  // str is the string you are searching
    if (c == '(') {
        if (brackets == 0) {
            count++;
        }
        brackets++;
    }
    else if (c == ')') {
        brackets--;
    }
}return count;
  }
}