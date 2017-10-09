

public class Program {
  public static int Puzzle(String s) {
     int wordCount = 0;

    if (s.trim().equals("")) {
        return wordCount;
    }
    else {
        wordCount = 1;
    }

    for (int i = 0; i < s.length(); i++) {
        char ch = s.charAt(i);
        String str = new String("" + ch);
        if (i+1 != s.length() && str.equals(" ") && !(""+ s.charAt(i+1)).equals(" ")) {
            wordCount++;
        }
    }

    return wordCount;
    
	}
  }
