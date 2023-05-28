// See https://aka.ms/new-console-template for more information

Console.WriteLine("enter inpuut");
string? input = Console.ReadLine();

var numbers = (input ?? String.Empty)
    .ToList<char>()
    .ConvertAll<int>(c => (int)c);

var result = new System.Text.StringBuilder();
for (int i = 0; i < numbers.Count; i++)
{
    result.Append(
        Convert.ToString(numbers[i], 2)
            .Replace('0', 'Г')
            .Replace('1', 'А')
    );
}

Console.WriteLine(result);
