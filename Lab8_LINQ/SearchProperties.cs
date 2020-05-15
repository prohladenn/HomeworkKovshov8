using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab8_LINQ
{
    /// <summary>
    /// Форма поиска
    /// </summary>
    public partial class SearchProperties : Form
    {
        private readonly TextBox textBox;
        public SearchProperties(TextBox textBox)
        {
            InitializeComponent();
            this.textBox = textBox;
            btnApply.Click += new EventHandler(OnBtnApplyClick);
        }
        /// <summary>
        /// Вызов метода, который выведет на экран найденные автомобили
        /// </summary>
        private void OnBtnApplyClick(object sender, EventArgs e)
        {
            try
            {
                var searchResult = Search(searchParam.SelectedIndex, paramTxtBox.Text);
                MainForm.PrintElements(textBox, searchResult);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка:\n" + ex.Message, "Ошибка");
            }
            this.Close();
        }

        /// <summary>
        /// Метод, который выводит на экран, найденные автомобили
        /// </summary>
        /// <param name="paramIndex">Номер параметра для сравнения</param>
        /// <param name="str">Подстрока, по которой нужно найти автомобили</param>
        public List<XElement> Search(int paramIndex, string paramValue)
        {
            string param = "";
            List<XElement> ans = new List<XElement>();
            switch (paramIndex)
            {
                case 0:
                    param = "surname";
                    break;
                case 1:
                    param = "brand";
                    break;
                case 2:
                    param = "gasoline";
                    break;
                case 3:
                    param = "enginePower";
                    break;
            }
            try
            {
                var res = XDocument.Load(MainForm.source)
                    .Element("cars")
                    .Elements("car")
                    .Where(s => s.Element(param).Value.ToLower().Contains(paramValue.ToLower()));
                foreach (XElement xe in res)
                {
                    ans.Add(xe);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка:\n" + ex.Message, "Ошибка");
            }
            return ans;
        }
    }
}
