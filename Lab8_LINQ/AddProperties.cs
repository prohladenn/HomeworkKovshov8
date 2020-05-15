using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab8_LINQ
{
    /// <summary>
    /// Форма добавления
    /// </summary>
    public partial class AddProperties : Form
    {
        private readonly TextBox textBox;
        public AddProperties(TextBox textBox)
        {
            InitializeComponent();
            this.textBox = textBox;
            btnAdd.Click += new EventHandler(OnBtnAddClick);
        }
        /// <summary>
        /// Добавление автомобиля
        /// </summary>
        private void OnBtnAddClick(object sender, EventArgs e)
        {
            if (surnameTxtBox.Text != "" && brandIdTxtBox.Text != ""
                && brandTxtBox.Text != "" && gasolineTxtBox.Text != ""
                && volumeTankTxtBox.Text != "" && enginePowerTxtBox.Text != ""
                && remainingGasTxtBox.Text != "" && volumeOilTxtBox.Text != "")
            { 
                try
                {
                    var addResult = AddElement(
                        surnameTxtBox.Text,
                        brandIdTxtBox.Text,
                        brandTxtBox.Text,
                        gasolineTxtBox.Text,
                        enginePowerTxtBox.Text,
                        volumeTankTxtBox.Text,
                        remainingGasTxtBox.Text,
                        volumeOilTxtBox.Text);
                    MainForm.PrintElements(textBox, addResult);
                } catch
                {
                    MessageBox.Show("Ошибка записи в файл");
                }
            } else
            {
                MessageBox.Show("Ошибка! Некорректные введённые данные.");
            }
            this.Close();
        }

        public IEnumerable<XElement> AddElement(
            string surname,
            string brandId,
            string brand,
            string gasoline,
            string enginePower,
            string volumeTank,
            string remainingGas,
            string volumeOil)
        {
            XDocument xdoc = XDocument.Load(MainForm.source);
            xdoc.Element("cars").Add(new XElement("car",
                new XElement("surname", surname),
                new XElement("brandId", brandId),
                new XElement("brand", brand),
                new XElement("gasoline", gasoline),
                new XElement("enginePower", enginePower),
                new XElement("volumeTank", volumeTank),
                new XElement("remainingGas", remainingGas),
                new XElement("volumeOil", volumeOil)));
            xdoc.Save(MainForm.source);
            return xdoc.Element("cars").Elements("car");
        }
    }
}
