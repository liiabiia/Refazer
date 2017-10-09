

public class Program {
  public static int Puzzle(String s) {
     int wordCount = 0;
     s= s.trim();			a
    if (s.equals("")) {
        return wordCount;
    }
    else {
        wordCount = 1;
    }

    for (int i = 0; i < s.length()-1; i++) {
       if(s.charAt(i)==' ' &&s.charAt(i+1)!=' ')
       {
            wordCount++;
        }
    }

    return wordCount;
    
	}
  }
