using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Aspose.Pdf.Text;
using Aspose.Pdf;

namespace WindowsFormsApp1.Data
{
    internal class Connection
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=192.168.1.91;port=3306;username=vika;password=123321123321;database=new_schema";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void Create_pdf()
        {
            Document doc = new Document();
            Page page1 = doc.Pages.Add();
            TextFragment fuel_type = new TextFragment($"Тип топлива: {@public.tiptopl}");

            fuel_type.Position = new Position(200, 700);
            fuel_type.TextState.FontSize = 20;
            fuel_type.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            fuel_type.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextBuilder builder1 = new TextBuilder(page1);
            builder1.AppendText(fuel_type);


            TextFragment number_column = new TextFragment($"Номер колонки: {@public.nomerkol}");

            number_column.Position = new Position(200, 660);
            number_column.TextState.FontSize = 20;
            number_column.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            number_column.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextBuilder builder2 = new TextBuilder(page1);
            builder2.AppendText(number_column);


            TextFragment amount_litres = new TextFragment($"Кол-во литров: {@public.kollitr}");

            amount_litres.Position = new Position(200, 620);
            amount_litres.TextState.FontSize = 20;
            amount_litres.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            amount_litres.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextBuilder builder3 = new TextBuilder(page1);
            builder3.AppendText(amount_litres);


            TextFragment result = new TextFragment($"Итог: {@public.itog}");

            result.Position = new Position(200, 580);
            result.TextState.FontSize = 20;
            result.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            result.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextBuilder builder4 = new TextBuilder(page1);
            builder4.AppendText(result);



            TextFragment time_of_purchase = new TextFragment($"Время покупки: {@public.vremjapokupki}");

            time_of_purchase.Position = new Position(200, 540);
            time_of_purchase.TextState.FontSize = 20;
            time_of_purchase.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            time_of_purchase.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextBuilder builder5 = new TextBuilder(page1);
            builder5.AppendText(time_of_purchase);


            TextFragment date_of_purchase = new TextFragment($"Дата покупки: {@public.datapokupki}");

            date_of_purchase.Position = new Position(200, 500);
            date_of_purchase.TextState.FontSize = 20;
            date_of_purchase.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            date_of_purchase.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextBuilder builder6 = new TextBuilder(page1);
            builder6.AppendText(date_of_purchase);

            doc.Save("C:\\Users\\Public\\Documents\\check.pdf");
        }
    }
}
