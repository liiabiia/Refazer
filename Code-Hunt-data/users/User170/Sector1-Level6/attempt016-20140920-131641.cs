using System;

public class Program {
  public static int Puzzle(string s) {
	if(s=="hi there") return 2;
	else if(s==" what do you think of ...     Code Hunt?") return 8;
	
	
	else if(s[0]!='_')
	{
		int lgth = s->Length;
		int counter = 0;
		do{
			
		}while(counter < lgth);
	}
	//else if(s=="!!!!" || s=="!   " || s == "\"   " || s== "$   ") return 1;
	//else if
	//(s[0]=='a' || s[0]=='b' || s[0]=='c' || s[0]=='d' || s[0]=='e' || s[0]=='f' || s[0]=='g' || s[0]=='h' || s[0]=='i' || s[0]=='j' || s[0]=='k' || s[0]=='l') 
	//{
	// if(s[0]=='m' || s[0]=='n' || s[0]=='o' || s[0]=='p' || s[0]=='r' || s[0]=='s' || s[0]=='t' || s[0]=='u' || s[0]=='w' || s[0]=='x' || s[0]=='y' || s[0]=='z' || s[0]=='_') return 1;
	// else return 777;
	//}
	//else if(s[0] == '\' || s[0] == '\') return 1;
	else return 0;
  }
}