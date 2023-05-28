// See https://aka.ms/new-console-template for more information

Console.WriteLine("encode://press 1 or decode://press 0");
string option = Console.ReadLine() ?? "0";

Console.WriteLine("\nalso enter text");
string input = Console.ReadLine() ?? String.Empty;

bool isDecode = option == "0";

if (isDecode && !Library.IsDecodable(input))
{
    Console.WriteLine("error://string_non_parsable");
    Environment.Exit(1);
}

string result = isDecode
    ? (Library.IsDecodable(input) ? Library.TranslateToText(input) : String.Empty)
    : Library.TranslateToGaaga(input);

Console.WriteLine("result");
Console.WriteLine(result);
