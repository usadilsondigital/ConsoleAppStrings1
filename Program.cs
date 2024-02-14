string phrase = "The quick brown fox jumps over the lazy dog.";
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
