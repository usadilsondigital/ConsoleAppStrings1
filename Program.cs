﻿string phrase = "The quick brown fox jumps over the lazy dog.";
string[] words = phrase.Split(' ');

foreach (var word in words)
{
    System.Console.WriteLine($"<{word}>");
}



string phrase1 = "The quick brown    fox     jumps over the lazy dog.";
string[] words1 = phrase1.Split(' ');

foreach (var word in words1)
{
    System.Console.WriteLine($"<{word}>");
}

///---------------
///You can pass an optional StringSplitOptions.RemoveEmptyEntries parameter to exclude any 
///strings in the returned array. For more complicated processing of the returned collection, 
///you can use LINQ to manipulate the result sequence.
///String.Split can use multiple separator characters. 
char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

string text = "one\ttwo three:four,five six seven";
System.Console.WriteLine($"Original text: '{text}'");


string[] words2 = text.Split(delimiterChars);
System.Console.WriteLine($"{words2.Length} words in text:");

foreach (var word in words2)
{
    System.Console.WriteLine($"<{word}>");
}


///Consecutive instances of any separator produce the empty string in the output array:
///

string text2 = "one\ttwo :,five six seven";
System.Console.WriteLine($"Original text2: '{text2}'");

string[] words3 = text2.Split(delimiterChars);
System.Console.WriteLine($"{words3.Length} words in text:");

foreach (var word in words3)
{
    System.Console.WriteLine($"<{word}>");
}


///String.Split can take an array of strings (character sequences 
///that act as separators for parsing the target string, instead of single charactersz).

string[] separatingStrings = { "<<", "..." };

string text4 = "one<<two......three<four";
System.Console.WriteLine($"Original text: '{text4}'");

string[] words4 = text4.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
System.Console.WriteLine($"{words4.Length} substrings in text:");

foreach (var word in words4)
{
    System.Console.WriteLine(word);
}


////
///
string s = "You win some. You lose some.";

string[] subs = s.Split();

foreach (string sub in subs)
{
    Console.WriteLine($"Substring: {sub}");
}

String[] expressions = { "16 + 21", "31 * 3", "28 / 3",
                       "42 - 18", "12 * 7",
                       "2, 4, 6, 8" };
String pattern = @"(\d+)\s+([-+*/])\s+(\d+)";

foreach (string expression in expressions)
{

    foreach (System.Text.RegularExpressions.Match m in
  System.Text.RegularExpressions.Regex.Matches(expression, pattern))
    {
        int value1 = Int32.Parse(m.Groups[1].Value);
        int value2 = Int32.Parse(m.Groups[3].Value);

        switch (m.Groups[2].Value)
        {
            case "+":
                Console.WriteLine("{0} = {1}", m.Value, value1 + value2);
                break;
            case "-":
                Console.WriteLine("{0} = {1}", m.Value, value1 - value2);
                break;
            case "*":
                Console.WriteLine("{0} = {1}", m.Value, value1 * value2);
                break;
            case "/":
                Console.WriteLine("{0} = {1:N2}", m.Value, value1 / value2);
                break;
        }

    }
}


// The example displays the following output:
//       16 + 21 = 37
//       31 * 3 = 93
//       28 / 3 = 9.33
//       42 - 18 = 24
//       12 * 7 = 84




////////////////////////////////////////////////////////
///
String[] expressions2 = { "16 + 21", "31 * 3", "28 / 3",
                       "42 - 18", "12 * 7",
                       "2, 4, 6, 8" };

String pattern2 = @"(\d+)\s+([-+*/])\s+(\d+)";

foreach (string expression in expressions2)
{

    foreach (System.Text.RegularExpressions.Match m in
    System.Text.RegularExpressions.Regex.Matches(expression, pattern2)) {

        int value1 = Int32.Parse(m.Groups[1].Value);
        int value2 = Int32.Parse(m.Groups[3].Value);

        switch (m.Groups[2].Value)
        {
            case "+":
                Console.WriteLine("{0} = {1}", m.Value, value1 + value2);
                break;
            case "-":
                Console.WriteLine("{0} = {1}", m.Value, value1 - value2);
                break;
            case "*":
                Console.WriteLine("{0} = {1}", m.Value, value1 * value2);
                break;
            case "/":
                Console.WriteLine("{0} = {1:N2}", m.Value, value1 / value2);
                break;
        }
    }

}

// The example displays the following output:
//       16 + 21 = 37
//       31 * 3 = 93
//       28 / 3 = 9.33
//       42 - 18 = 24
//       12 * 7 = 84

////////////////////////////////////////////////////////////////////////////////
String input2 = "[This is captured\ntext.]\n\n[\n" +
               "[This is more captured text.]\n]\n" +
               "[Some more captured text:\n   Option1" +
               "\n   Option2][Terse text.]";
String pattern3 = @"\[([^\[\]]+)\]";
int ctr = 0;

foreach (System.Text.RegularExpressions.Match m in
   System.Text.RegularExpressions.Regex.Matches(input2, pattern3))
{
    Console.WriteLine("{0}: {1}", ++ctr, m.Groups[1].Value);
}

// The example displays the following output:
//       1: This is captured
//       text.
//       2: This is more captured text.
//       3: Some more captured text:
//          Option1
//          Option2
//       4: Terse text.

///////////////////////////////////////
String input4 = "abacus -- alabaster - * - atrium -+- " +
               "any -*- actual - + - armoire - - alarm";

String pattern4 = @"\s-\s?[+*]?\s?-\s";

String[] elements = System.Text.RegularExpressions.Regex.Split(input4, pattern4);

foreach (string element in elements)
    Console.WriteLine(element);

// The example displays the following output:
//       abacus
//       alabaster
//       atrium
//       any
//       actual
//       armoire
//       alarm

/////////////////////////////////////////////
///
String s5 = "This is the first sentence in a string. " +
               "More sentences will follow. For example, " +
               "this is the third sentence. This is the " +
               "fourth. And this is the fifth and final " +
               "sentence.";
var sentences = new List<String>();
int start = 0;
int position;

// Extract sentences from the string.
do
{
    position = s.IndexOf('.', start);
    if (position >= 0)
    {
        sentences.Add(s.Substring(start, position - start + 1).Trim());
        start = position + 1;
    }
} while (position > 0);


// Display the sentences.
foreach (var sentence in sentences)
    Console.WriteLine(sentence);

// The example displays the following output:
//       This is the first sentence in a string.
//       More sentences will follow.
//       For example, this is the third sentence.
//       This is the fourth.
//       And this is the fifth and final sentence.


////////////////////////////////////
///
string name = "Alex Johnson III";

string[] subs6 = name.Split(null, 2);


string firstName = subs[0];
string lastName;

if (subs6.Length > 1)
{
    lastName = subs6[1];
}// firstName = "Alex"
 // lastName = "Johnson III"

////////////////////////
string phrase7 = "The quick  brown fox";

_ = phrase7.Split(default(char[]), StringSplitOptions.RemoveEmptyEntries);

_ = phrase7.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries);

_ = phrase7.Split(null as char[], StringSplitOptions.RemoveEmptyEntries);