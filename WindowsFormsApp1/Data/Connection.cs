using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Aspose.Pdf.Text;
using Aspose.Pdf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq.Expressions;

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
            Aspose.Pdf.Page page1 = doc.Pages.Add();
            try
            {
                if (@public.nomerkol == "1")
                {
                    TextFragment number_column1 = new TextFragment($"Номер колонки: 1");

                    number_column1.Position = new Position(200, 660);
                    number_column1.TextState.FontSize = 20;
                    number_column1.TextState.Font = FontRepository.FindFont("TimesNewRoman");
                    number_column1.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextBuilder builder2 = new TextBuilder(page1);
                    builder2.AppendText(number_column1);
                }
                if (@public.nomerkol == "2")
                {
                    TextFragment number_column2 = new TextFragment($"Номер колонки: 2");

                    number_column2.Position = new Position(200, 660);
                    number_column2.TextState.FontSize = 20;
                    number_column2.TextState.Font = FontRepository.FindFont("TimesNewRoman");
                    number_column2.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextBuilder builder14 = new TextBuilder(page1);
                    builder14.AppendText(number_column2);
                }
                if (@public.nomerkol == "3")
                {
                    TextFragment number_column3 = new TextFragment($"Номер колонки: 3");

                    number_column3.Position = new Position(200, 660);
                    number_column3.TextState.FontSize = 20;
                    number_column3.TextState.Font = FontRepository.FindFont("TimesNewRoman");
                    number_column3.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextBuilder builder15 = new TextBuilder(page1);
                    builder15.AppendText(number_column3);
                }
                if (@public.nomerkol == "4")
                {
                    TextFragment number_column4 = new TextFragment($"Номер колонки: 4");

                    number_column4.Position = new Position(200, 660);
                    number_column4.TextState.FontSize = 20;
                    number_column4.TextState.Font = FontRepository.FindFont("TimesNewRoman");
                    number_column4.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextBuilder builder16 = new TextBuilder(page1);
                    builder16.AppendText(number_column4);
                }
            }
            catch { };


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
         
            try
            {
                if (@public.cena_litra == "1")
                {
                    TextFragment cena_litra92 = new TextFragment($"Стоимость 1 литра: {@public.cena_litra92}");

                    cena_litra92.Position = new Position(200, 460);
                    cena_litra92.TextState.FontSize = 20;
                    cena_litra92.TextState.Font = FontRepository.FindFont("TimesNewRoman");
                    cena_litra92.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextBuilder builder7 = new TextBuilder(page1);
                    builder7.AppendText(cena_litra92);

                    TextFragment fuel_type = new TextFragment($"Тип топлива: 92");

                    fuel_type.Position = new Position(200, 700);
                    fuel_type.TextState.FontSize = 20;
                    fuel_type.TextState.Font = FontRepository.FindFont("TimesNewRoman");
                    fuel_type.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextBuilder builder1 = new TextBuilder(page1);
                    builder1.AppendText(fuel_type);
                    

                }
                if (@public.cena_litra == "2")
                {
                    TextFragment cena_litra95 = new TextFragment($"Стоимость 1 литра: {@public.cena_litra95}");

                    cena_litra95.Position = new Position(200, 460);
                    cena_litra95.TextState.FontSize = 20;
                    cena_litra95.TextState.Font = FontRepository.FindFont("TimesNewRoman");
                    cena_litra95.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextBuilder builder8 = new TextBuilder(page1);
                    builder8.AppendText(cena_litra95);

                    TextFragment fuel_type2 = new TextFragment($"Тип топлива: 95");

                    fuel_type2.Position = new Position(200, 700);
                    fuel_type2.TextState.FontSize = 20;
                    fuel_type2.TextState.Font = FontRepository.FindFont("TimesNewRoman");
                    fuel_type2.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextBuilder builder11 = new TextBuilder(page1);
                    builder11.AppendText(fuel_type2);

                    

                }
                if (@public.cena_litra == "3")
                {
                    TextFragment cena_litraDT = new TextFragment($"Стоимость 1 литра: {@public.cena_litraDT}");

                    cena_litraDT.Position = new Position(200, 460);
                    cena_litraDT.TextState.FontSize = 20;
                    cena_litraDT.TextState.Font = FontRepository.FindFont("TimesNewRoman");
                    cena_litraDT.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextBuilder builder9 = new TextBuilder(page1);
                    builder9.AppendText(cena_litraDT);
                    TextFragment fuel_type3 = new TextFragment($"Тип топлива: ДТ");

                    fuel_type3.Position = new Position(200, 700);
                    fuel_type3.TextState.FontSize = 20;
                    fuel_type3.TextState.Font = FontRepository.FindFont("TimesNewRoman");
                    fuel_type3.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextBuilder builder12 = new TextBuilder(page1);
                    builder12.AppendText(fuel_type3);

                }
                if (@public.cena_litra == "4")
                {
                    TextFragment cena_litra92p = new TextFragment($"Стоимость 1 литра: {@public.cena_litra92p}");

                    cena_litra92p.Position = new Position(200, 460);
                    cena_litra92p.TextState.FontSize = 20;
                    cena_litra92p.TextState.Font = FontRepository.FindFont("TimesNewRoman");
                    cena_litra92p.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextBuilder builder10 = new TextBuilder(page1);
                    builder10.AppendText(cena_litra92p);

                    TextFragment fuel_type4 = new TextFragment($"Тип топлива: 92p");

                    fuel_type4.Position = new Position(200, 700);
                    fuel_type4.TextState.FontSize = 20;
                    fuel_type4.TextState.Font = FontRepository.FindFont("TimesNewRoman");
                    fuel_type4.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextBuilder builder13 = new TextBuilder(page1);
                    builder13.AppendText(fuel_type4);

                }
            }
            catch { };

            doc.Save("C:\\Users\\Public\\Documents\\check.pdf");

        }
    }
}
