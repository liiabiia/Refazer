

public class Program {
  public static int Puzzle(String s) {
     int wordCount = 0;

    if (input.trim().equals("")) {
        return wordCount;
    }
    else {
        wordCount = 1;
    }

    for (int i = 0; i < input.length(); i++) {
        char ch = input.charAt(i);
        String str = new String("" + ch);
        if (i+1 != input.length() && str.equals(" ") && !(""+ input.charAt(i+1)).equals(" ")) {
            wordCount++;
        }
    }

    return wordCount;
    
	}
  }
