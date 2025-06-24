char[] str = new char[100];

str[0] = 'a';
str[1] = 'b';
str[2] = 'c';

Console.WriteLine(str);

string s = "Shahriar";

Console.WriteLine(s);
Console.WriteLine(s.Length);

char[] arr = s.ToCharArray();

Array.Reverse(arr);

string s2 = new string(arr);

if (s == s2) {
  Console.WriteLine("Palindrome");
} else {
  Console.WriteLine("Not Palindrome");
}

// array of string
string[] aos = new string[20];

for (int i = 0; i < 20; i++) {
  aos[i] = "X" + i;
}

  Console.WriteLine(aos[10]);

