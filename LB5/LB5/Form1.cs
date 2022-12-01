using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_FWDataSet.Shop". При необходимости она может быть перемещена или удалена.
            this.shopTableAdapter.Fill(this.dB_FWDataSet.Shop);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_FWDataSet.Factory". При необходимости она может быть перемещена или удалена.
            this.factoryTableAdapter.Fill(this.dB_FWDataSet.Factory);

        }
private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Товар не найден",
                "Сообщение");
        }
    }
}
    