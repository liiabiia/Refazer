using System;
using System.Linq;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        
		var groupJoin =
        a.GroupJoin(
           b,
            leftLetter => leftLetter,
            rightLetter => rightLetter,
            (leftLetter, matchingRightLetters) => new { leftLetter, matchingRightLetters }
        );
        int[] kanak = new int[array1.Length];
        int count=0;
        foreach (var row in groupJoin)
        {
            kanak[count] = row.leftLetter;
            count++;
        }
		return kanak;
		
    }
}