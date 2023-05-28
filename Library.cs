public static class Library
{
    public const int char_length = 16;
    public const char replace_0 = 'А';
    public const char replace_1 = 'Г';

    public static string GetNormalizedBinaryString(int code)
    {
        var result = Convert.ToString(code, 2);

        for (int i = result.Length; i < char_length; i++)
        {
            result = "0" + result;
        }

        return result;
    }

    public static string TranslateToGaaga(string input)
    {

        var numbers = input.ToList<char>()
            .ConvertAll<int>(c => (int)c);

        var result = new System.Text.StringBuilder();
        for (int i = 0; i < numbers.Count; i++)
        {
            result.Append(
                GetNormalizedBinaryString(numbers[i])
                    .Replace('0', replace_0)
                    .Replace('1', replace_1)
            );
        }

        return result.ToString();
    }

    public static string TranslateToText(string input)
    {
        var binary = input
            .Replace(replace_0, '0')
            .Replace(replace_1, '1');

        var result = "";
        for (int i = 0; i < binary.Length; i += char_length)
        {
            var code = binary.Substring(i, char_length);
            var symbol = (char)Convert.ToInt32(code, 2);
            result += symbol;
        }

        return result;
    }

    public static bool IsDecodable(string encoded)
        => encoded.ToList<char>().All<char>(c => c == replace_0 || c == replace_1);
}
