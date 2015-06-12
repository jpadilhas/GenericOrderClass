using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenarItens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Equals(""))
                return;
            this.lbItens.Items.AddRange(new object[] { txtNumber.Text });
            txtNumber.Text = "";
            txtNumber.Focus();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {            
            bool up = ((Button)sender).Tag.ToString().Equals("up") ? true : false;
            var data = new List<myDomainClass>();

            foreach (var listBoxItem in lbItens.Items)
            {
                data.Add(new myDomainClass(Convert.ToInt32(listBoxItem)));                
            }

            lbItens.Items.Clear();
            data.Sort(new myClass.myDomainClassOrder("itemValue", up));

            foreach (var item in data)
            {
                this.lbItens.Items.AddRange(new object[] { item.itemValue });
            }
        }
    }
}
