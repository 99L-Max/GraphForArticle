using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GraphForArticle
{
    static class FileReader
    {
        public static bool TryOpen(out double[,] array)
        {
            using (OpenFileDialog dialog = new OpenFileDialog { Filter = "Текстовые файлы|*.txt|Все файлы|*.*" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var data = File.ReadAllText(dialog.FileName);

                    data = data.Trim('\n');
                    data = data.Replace('\t', ' ');
                    data = data.Replace('.', ',');
                    data = Regex.Replace(data, @"([ ]){2,}", @"$1");

                    var lines = data.Split(new[] { Environment.NewLine, "\n" }, StringSplitOptions.None);
                    array = new double[lines.Length, lines[0].Count(symbol => symbol == ' ') + 1];

                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        var numbers = lines[i].Split(' ');

                        for (int j = 0; j < array.GetLength(1); j++)
                            if (double.TryParse(numbers[j], out double number))
                                array[i, j] = number;
                    }

                    return true;
                }
                else
                {
                    array = null;
                    return false;
                }
            }
        }
    }
}
