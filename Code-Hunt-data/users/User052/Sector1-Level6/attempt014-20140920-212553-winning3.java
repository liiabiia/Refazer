

public class Program {
  public static int Puzzle(String s) {
	  s=s.trim();
	  if (s == "")
       return 0;
    return s.trim().split("\\s+").length;
//     int wordCount = 0;
//     s= s.trim();			
//    if (s.equals("")) {
//        return wordCount;
//    }
//    else {
//        wordCount = 1;
//    }
//
//    for (int i = 0; i < s.length()-1; i++) {
//       if(s.charAt(i)==' ' &&s.charAt(i+1)!=' ')
//       {
//            wordCount++;
//        }
//    }
//    return wordCount;
//    
	}
  }
