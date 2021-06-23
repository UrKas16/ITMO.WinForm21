using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinForm.lab2.exp2
{
    public partial class listForm : Form
    {
        int i;
        public listForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //if (memberList.Items.Count != 0)
            //{
            //    for (i = memberList.Items.Count; i < memberList.Items.Count; i++)
            //    {
            //        if (peopleList.Items[0] == memberList.Items[i])
            //        {
            //            MessageBox.Show("Данные элемент уже есть в списке");
            //        }
            //        else
            //        {
            //            memberList.Items.Add(peopleList.Text);
            //        }
            //    }
            //}
            //else
            //{
            //    if (peopleList.Text.Length != 0)
            //    {
            //        memberList.Items.Add(peopleList.Text);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Выберите элемент из списка или введите новый.");
            //    }

            //}

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

    }
}
