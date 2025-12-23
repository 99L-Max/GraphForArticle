using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GraphForArticle
{
    static class FileWriter
    {
        public static void Save(Chart chart)
        {
            using (SaveFileDialog dialog = new SaveFileDialog { Filter = "Изображения|*.png" })
                if (dialog.ShowDialog() == DialogResult.OK)
                    chart.SaveImage(dialog.FileName, ImageFormat.Png);
        }
    }
}
