using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ITMO.WinForm.lab2.exp2
{
    public partial class listForm : Form
    {
        //int i;
        public listForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (peopleList.Text.Length != 0)
            {
                memberList.Items.Add(peopleList.Text);
            }
            else
            {
                MessageBox.Show("Выберите элемент из списка или введите новый.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            while (memberList.CheckedIndices.Count > 0)
            {
                memberList.Items.RemoveAt(memberList.CheckedIndices[0]);
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            memberList.Sorted = true;
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            peopleList.Items.Clear();

            FileStream fStream = new FileStream(
                "C:\\Users\\kasyu\\source\\repos\\ITMO.WinForm.exp1\\ITMO.WinForm.lab2.exp2\\XMLData..xml",
                FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(fStream);

            for (int i = 0; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
            {
                peopleList.Items.Add(xmlDoc.DocumentElement.ChildNodes[i].InnerText);
            }

            fStream.Close();
        }
    }
}
