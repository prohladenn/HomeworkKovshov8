using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab8_LINQ
{
    /*
     * Один элемент ‒ автомобиль ‒ представляет собой в базе данных структуру с полями:
     * фамилия владельца,
     * код марки автомобиля,
     * марка автомобиля,
     * требуемая марка бензина,
     * мощность двигателя, объем бака,
     * остаток бензина, объем масла.
     * Дана фиксированная цена литра бензина и заливки масла.
     * Организовать поиск по марке автомобиля, марке бензина, мощности двигателя, фамилии владельца.
     */
    public partial class MainForm : Form
    {
        public static int gasPrice=0, oilPrice=0;
        public static string source = "../../../source.xml";
        public MainForm()
        {
            InitializeComponent();
            ShowAll(null, null);
            this.showAllToolStripMenuItem.Click += new EventHandler(ShowAll);
            this.deleteToolStripMenuItem.Click += new EventHandler(OnDelClick);
            this.setSearchToolStripMenuItem.Click += new EventHandler(OnSetSearchClick);
        }
        /// <summary>
        /// Вывести все автомобили
        /// </summary>
        public void ShowAll(object sender, EventArgs e)
        {
            try
            {
                XDocument xdoc = XDocument.Load(source);
                var cars = xdoc.Element("cars");
                gasPrice = Int32.Parse(cars.Element("gasPrice").Value);
                oilPrice = Int32.Parse(cars.Element("oilPrice").Value);
                tableView.Text = "";
                foreach (XElement xe in cars.Elements("car"))
                {
                    tableView.Text += GetCarsInfo(xe);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка:\n" + ex.Message, "Ошибка");
            }
        }
        /// <summary>
        /// Получение информации об автомобиле в виде строки
        /// </summary>
        /// <param name="xe">XElement с информацией об автомобилях</param>
        /// <returns>Информация об автомобиле</returns>
        public static string GetCarsInfo(XElement xe)
        {
            string info = "";
            XElement surname = xe.Element("surname");
            XElement brandId = xe.Element("brandId");
            XElement brand = xe.Element("brand");
            XElement gasoline = xe.Element("gasoline");
            XElement enginePower = xe.Element("enginePower");
            XElement volumeTank = xe.Element("volumeTank");
            XElement remainingGas = xe.Element("remainingGas");
            XElement volumeOil = xe.Element("volumeOil");

            if (surname != null && brandId != null && brand != null && gasoline != null && volumeTank != null &&
                enginePower != null && remainingGas != null && volumeOil != null &&
                surname.Value != "" && brandId.Value != "" && brand.Value != "" && gasoline.Value != "" &&
                enginePower.Value != "" && remainingGas.Value != "" && volumeOil.Value != "")
            {
                info = "Фамилия: " + surname.Value + Environment.NewLine +
                    "Код марки: " + brandId.Value + Environment.NewLine +
                    "Марка автомобиля: " + brand.Value + Environment.NewLine +
                    "Требуемая марка бензина: " + gasoline.Value + Environment.NewLine +
                    "Мощность двигателя: " + enginePower.Value + Environment.NewLine +
                    "Объём бака: " + volumeTank.Value + Environment.NewLine +
                    "Остаток бензина: " + remainingGas.Value + Environment.NewLine +
                    "Объём масла: " + volumeOil.Value + Environment.NewLine +
                    "Цена литра бензина: " + gasPrice + Environment.NewLine +
                    "Цена заливки масла: " + oilPrice + Environment.NewLine + Environment.NewLine;
            }
            return info;
        }

        public static void PrintElements(TextBox textBox, IEnumerable<XElement> xElements)
        {
            textBox.Text = "";
            foreach (XElement xe in xElements)
            {
                textBox.Text += MainForm.GetCarsInfo(xe);
            }
        }
        /// <summary>
        /// Открытие формы с изменением параметров поиска
        /// </summary>
        private void OnSetSearchClick(object sender, EventArgs e)
        {
            SearchProperties searchProperties = new SearchProperties(tableView);
            searchProperties.Show();
        }
        /// <summary>
        /// Открытие формы добавления автомобилей
        /// </summary>
        private void OnAddClick(object sender, EventArgs e)
        {
            AddProperties addProperties = new AddProperties(tableView);
            addProperties.Show();
        }
        /// <summary>
        /// Открытие формы удаления автомобиля
        /// </summary>
        private void OnDelClick(object sender, EventArgs e)
        {
            Delete delete = new Delete(tableView);
            delete.Show();
        }
       
        public void SetText(string str)
        {
            tableView.Text = str;
        }
    }
}
