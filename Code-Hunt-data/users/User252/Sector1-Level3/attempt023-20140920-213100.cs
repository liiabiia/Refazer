using System;
public class Program {
public static bool Puzzle(bool x, bool y, bool z) {
if(x==false&&y==false&&z==false) {
z=false;
    return z; }
if(x==true&&y==true&&z==true) {
z=true;
return z; }
if(x==false&&y==a&&z==true) {
	bool a=true(0X02);
z=false;
return z; }
if(x==false&&y==b&z==true)
{
	bool b=true;
	z=b;
	return z;
}
if(x==true&&y==false&&z==false) {
z=true;
return z; }
if(x==true&&y==true&z==false)
{ z=true; return z; }
if(x==false&&y==false&&z==true)
{ z=false; return z; }
if(x==false&&y==true&&z==false)
{ z=false; return z;
}
if(x==true&&y==false&&z==true)
{ z=true; return z; }
if(x==true&&y==true&&z==false)
{ z=true; return z; }
else return true;
  }
}