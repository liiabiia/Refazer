

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
       if(s.charAt(i)==' ' &&s.charAt(i+1)!=' ')
       {
            wordCount++;
        }
    }

    return wordCount;
    
	}
  }
