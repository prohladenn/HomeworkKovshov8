using Lab8_LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Windows.Forms;

namespace Lab8_Test
{
    [TestClass]
    public class MainTest
    {
        private static string sourcesPath = "../../../../Lab8_Test/sources/";

        [TestMethod]
        public void TestParseOneCar()
        {
            string expected = "�������: �����" + Environment.NewLine +
                    "��� �����: 3" + Environment.NewLine +
                    "����� ����������: �����" + Environment.NewLine +
                    "��������� ����� �������: gas3" + Environment.NewLine +
                    "�������� ���������: 100" + Environment.NewLine +
                    "����� ����: 60" + Environment.NewLine +
                    "������� �������: 10" + Environment.NewLine +
                    "����� �����: 4" + Environment.NewLine +
                    "���� ����� �������: 50" + Environment.NewLine +
                    "���� ������� �����: 40" + Environment.NewLine + Environment.NewLine;
            MainForm.source = sourcesPath + "f1.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }

        [TestMethod]
        public void TestParseTwoCars()
        {
            string expected = "�������: �����" + Environment.NewLine +
                    "��� �����: 3" + Environment.NewLine +
                    "����� ����������: �����" + Environment.NewLine +
                    "��������� ����� �������: gas3" + Environment.NewLine +
                    "�������� ���������: 100" + Environment.NewLine +
                    "����� ����: 60" + Environment.NewLine +
                    "������� �������: 10" + Environment.NewLine +
                    "����� �����: 4" + Environment.NewLine +
                    "���� ����� �������: 50" + Environment.NewLine +
                    "���� ������� �����: 40" + Environment.NewLine + Environment.NewLine +
                    "�������: �����" + Environment.NewLine +
                    "��� �����: 3" + Environment.NewLine +
                    "����� ����������: �����" + Environment.NewLine +
                    "��������� ����� �������: gas3" + Environment.NewLine +
                    "�������� ���������: 100" + Environment.NewLine +
                    "����� ����: 60" + Environment.NewLine +
                    "������� �������: 10" + Environment.NewLine +
                    "����� �����: 4" + Environment.NewLine +
                    "���� ����� �������: 50" + Environment.NewLine +
                    "���� ������� �����: 40" + Environment.NewLine + Environment.NewLine;
            MainForm.source = sourcesPath + "f2.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }

        [TestMethod]
        public void TestParseNoCar()
        {
            string expected = "";
            MainForm.source = sourcesPath + "f3.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }

        [TestMethod]
        public void TestParseNoName()
        {
            string expected = "";
            MainForm.source = sourcesPath + "f4.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }

        [TestMethod]
        public void TestParseNoBrandId()
        {
            string expected = "";
            MainForm m = new MainForm();
            MainForm.source = sourcesPath + "f5.xml";
            Assert.AreEqual(m.tableView.Text, expected);
        }

        [TestMethod]
        public void TestParseNoBrand()
        {
            string expected = "";
            MainForm.source = sourcesPath + "f6.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        [TestMethod]
        public void TestParseNoGasoline()
        {
            string expected = "";
            MainForm.source = sourcesPath + "f7.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        [TestMethod]
        public void TestParseNoEnginePower()
        {
            string expected = "";
            MainForm.source = sourcesPath + "f8.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        [TestMethod]
        public void TestParseNoVolumeTank()
        {
            string expected = "";
            MainForm.source = sourcesPath + "f9.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        [TestMethod]
        public void TestParseNoVolumeOil()
        {
            string expected = "";
            MainForm.source = sourcesPath + "f10.xml";
            MainForm m = new MainForm();
           
            Assert.AreEqual(m.tableView.Text, expected);
        }
        [TestMethod]
        public void TestAddElement()
        {
            ClearIfExists("f11.xml");
            string expected = "�������: 1" + Environment.NewLine +
                    "��� �����: 2" + Environment.NewLine +
                    "����� ����������: 3" + Environment.NewLine +
                    "��������� ����� �������: 4" + Environment.NewLine +
                    "�������� ���������: 5" + Environment.NewLine +
                    "����� ����: 6" + Environment.NewLine +
                    "������� �������: 7" + Environment.NewLine +
                    "����� �����: 8" + Environment.NewLine +
                    "���� ����� �������: 0" + Environment.NewLine +
                    "���� ������� �����: 0" + Environment.NewLine + Environment.NewLine;
            MainForm.source = sourcesPath + "f11.xml";
            TextBox textBox = new TextBox();
            AddProperties addProperties = new AddProperties(null);
            var addResult = addProperties.AddElement("1", "2", "3", "4", "5", "6", "7", "8");
            MainForm.PrintElements(textBox, addResult);
            Assert.AreEqual(textBox.Text, expected);
        }

        [TestMethod]
        public void TestFindTwoCars()
        {
            string expected = "�������: �����" + Environment.NewLine +
                    "��� �����: 3" + Environment.NewLine +
                    "����� ����������: �����" + Environment.NewLine +
                    "��������� ����� �������: gas3" + Environment.NewLine +
                    "�������� ���������: 100" + Environment.NewLine +
                    "����� ����: 60" + Environment.NewLine +
                    "������� �������: 10" + Environment.NewLine +
                    "����� �����: 4" + Environment.NewLine +
                    "���� ����� �������: 0" + Environment.NewLine +
                    "���� ������� �����: 0" + Environment.NewLine + Environment.NewLine +
                    "�������: �����" + Environment.NewLine +
                    "��� �����: 3" + Environment.NewLine +
                    "����� ����������: �����" + Environment.NewLine +
                    "��������� ����� �������: gas4" + Environment.NewLine +
                    "�������� ���������: 100" + Environment.NewLine +
                    "����� ����: 60" + Environment.NewLine +
                    "������� �������: 10" + Environment.NewLine +
                    "����� �����: 4" + Environment.NewLine +
                    "���� ����� �������: 0" + Environment.NewLine +
                    "���� ������� �����: 0" + Environment.NewLine + Environment.NewLine;
            MainForm.source = sourcesPath + "f12.xml";
            TextBox textBox = new TextBox();
            SearchProperties searchProperties = new SearchProperties(null);
            var searchResult = searchProperties.Search(0, "�����");
            MainForm.PrintElements(textBox, searchResult);
            Assert.AreEqual(textBox.Text, expected);
        }

        [TestMethod]
        public void TestFindOneCars()
        {
            string expected = "�������: �����" + Environment.NewLine +
                    "��� �����: 3" + Environment.NewLine +
                    "����� ����������: �����" + Environment.NewLine +
                    "��������� ����� �������: gas5" + Environment.NewLine +
                    "�������� ���������: 100" + Environment.NewLine +
                    "����� ����: 60" + Environment.NewLine +
                    "������� �������: 10" + Environment.NewLine +
                    "����� �����: 4" + Environment.NewLine +
                    "���� ����� �������: 0" + Environment.NewLine +
                    "���� ������� �����: 0" + Environment.NewLine + Environment.NewLine;
            MainForm.source = sourcesPath + "f12.xml";
            TextBox textBox = new TextBox();
            SearchProperties searchProperties = new SearchProperties(null);
            var searchResult = searchProperties.Search(2, "gas5");
            MainForm.PrintElements(textBox, searchResult);
            Assert.AreEqual(textBox.Text, expected);
        }

        [TestMethod]
        public void TestFindZeroCars()
        {
            string expected = "";
            MainForm.source = sourcesPath + "f12.xml";
            TextBox textBox = new TextBox();
            SearchProperties searchProperties = new SearchProperties(null);
            var searchResult = searchProperties.Search(3, "LOL KEK");
            MainForm.PrintElements(textBox, searchResult);
            Assert.AreEqual(textBox.Text, expected);
        }

        [TestMethod]
        public void TestRemoveOneElements()
        {
            ClearIfExists("f13.xml");
            string expected = "";
            MainForm.source = sourcesPath + "f13.xml";
            TextBox textBox = new TextBox();
            new AddProperties(null).AddElement("1", "2", "3", "4", "5", "6", "7", "8");
            Delete delete = new Delete(null);
            var deleteResult = delete.DeleteElements("1");
            MainForm.PrintElements(textBox, deleteResult);
            Assert.AreEqual(textBox.Text, expected);
        }

        [TestMethod]
        public void TestRemoveTwoElements()
        {
            ClearIfExists("f14.xml");
            string expected = "";
            MainForm.source = sourcesPath + "f14.xml";
            TextBox textBox = new TextBox();
            new AddProperties(null).AddElement("1", "2", "3", "4", "5", "6", "7", "8");
            new AddProperties(null).AddElement("1", "22", "33", "44", "55", "66", "77", "88");
            Delete delete = new Delete(null);
            var deleteResult = delete.DeleteElements("1");
            MainForm.PrintElements(textBox, deleteResult);
            Assert.AreEqual(textBox.Text, expected);
        }

        [TestMethod]
        public void TestRemoveZeroElements()
        {
            ClearIfExists("f15.xml");
            string expected = "";
            MainForm.source = sourcesPath + "f15.xml";
            TextBox textBox = new TextBox();
            Delete delete = new Delete(null);
            var deleteResult = delete.DeleteElements("1");
            MainForm.PrintElements(textBox, deleteResult);
            Assert.AreEqual(textBox.Text, expected);
        }

        private void ClearIfExists(string fileName)
        {
            if (File.Exists(sourcesPath + fileName))
            {
                File.Delete(sourcesPath + fileName);
                using var tw = new StreamWriter(sourcesPath + fileName, true);
                tw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                tw.WriteLine("<cars>");
                tw.WriteLine("</cars>");
            }
        }
    }
}
