using System;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GraphForArticle
{
    static class FileHandler
    {
        public static double[,] Open()
        {
            using (var ofDialog = new OpenFileDialog())
            {
                ofDialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";

                if (ofDialog.ShowDialog() != DialogResult.OK)
                    return null;

                var data = File.ReadAllText(ofDialog.FileName);

                //Подгонка под формат
                data = data.Trim('\n');
                data = data.Replace('\t', ' ');
                data = data.Replace('.', ',');
                data = Regex.Replace(data, @"([ ]){2,}", @"$1");

                var lines = data.Split(new[] { Environment.NewLine, "\n" }, StringSplitOptions.None);
                var result = new double[lines.Length, lines[0].Count(c => c == ' ') + 1];

                for (int i = 0; i < result.GetLength(0); i++)
                {
                    var numbers = lines[i].Split(' ');

                    for (int j = 0; j < result.GetLength(1); j++)
                        result[i, j] = double.Parse(numbers[j]);
                }

                return result;
            }
        }

        public static void Save(Chart chart)
        {
            using (var svDialog = new SaveFileDialog())
            {
                svDialog.Filter = "Изображения|*.png";

                if (svDialog.ShowDialog() != DialogResult.OK)
                    return;

                chart.SaveImage(svDialog.FileName, ImageFormat.Png);
            }
        }
    }
}
