using static System.Console;
using static System.Convert;
using static System.Math;


string str1 = ReadLine();
char[] arr = str1.ToCharArray();
Array.Reverse(arr);
string str2 = new string(arr);
WriteLine(str1+str2);