

public class Program {
  public static int Puzzle(String s) {
    int parents = 0;
    Deque<Character> deque = new LinkedList<>();
    for (char c : input.toCharArray()) {
        switch (c) {
            case '(':
                deque.addLast(c);
                break;
            case ')':
                deque.removeLast();
                if (deque.isEmpty()) {
                    parents++;
                }
                break;
        }
    }
    return parents;
  }
}