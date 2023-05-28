using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gaaga;

public static class Process
{
    public static List<int> TranslateToNumber(string str)
        => str.ToList().ConvertAll<int>(c => (int)c);

    public static string TranslateToBinary(string str)
    {
        var numberList = TranslateToNumber(str);
        var result = new StringBuilder();
        for (int i = 0; i < numberList.Count; i++)
        {
            result.Append(
                Convert.ToString(numberList[i], 2)
            );
        }
        return result.ToString();
    }

    public static string TranslateToArbitraryBinaryString(string str, char replace0, char replace1)
        => TranslateToBinary(str).Replace('0', replace0).Replace('1', replace1);

    public static string TranslateToGaaga(string str)
        => TranslateToArbitraryBinaryString(str, 'Г', 'А');
}
