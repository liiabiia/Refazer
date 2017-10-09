using System;

class Program {
public static int puzzle(int x)
{
if(x==0) return 42;
if(x==42) return 0;
if(x<42) {
x=x-42;
return x;
}
if(x>42) {
x=(-x)-42;
return x;
}
}
}