using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab8_LINQ
{
   /// <summary>
   /// Форма удаления
   /// </summary>
    public partial class Delete : Form
    {
        private readonly TextBox textBox;
        public Delete(TextBox textBox)
        {
            InitializeComponent();
            this.textBox = textBox;
            btnDel.Click += new EventHandler(OnBtnDelClick);
        }
        /// <summary>
        /// Удалить автомобиль по фамилии владельца
        /// </summary>
        private void OnBtnDelClick(object sender, EventArgs e)
        {
            try
            {
                var deleteResult = DeleteElements(delTxtBox.Text);
                MainForm.PrintElements(textBox, deleteResult);
            }
            catch (Exception)
            {
                MessageBox.Show("Не найден владелец: " + delTxtBox.Text,"Ошибка");
            }
            this.Close();
        }

        public IEnumerable<XElement> DeleteElements(string deleteUsername)
        {
            XDocument xdoc = XDocument.Load(MainForm.source);
            IEnumerable<XElement> deleteQuery = xdoc.Element("cars")
                .Elements("car")
                .Where(s => s.Element("surname").Value == deleteUsername);
            while (deleteQuery.Count() > 0)
            {
                deleteQuery.ElementAt(0).Remove();
                xdoc.Save(MainForm.source);
            }
            return xdoc.Element("cars").Elements("car");
        }
    }
}
