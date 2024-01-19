using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encounters
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        DataTable encounterTable;
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            encounterTable = new DataTable("Encounters");
            encounterTable.Columns.Add("Date", typeof(string));
            encounterTable.Columns.Add("Encounter History", typeof(string));

            var dataSet = new DataSet();
            dataSet.Tables.Add(encounterTable);
            dataSet.ReadXml("encounterHistory.xml");

            encounterDataTable.DataSource = encounterTable;
            encounterDataTable.Columns[0].Width = 269;
            encounterDataTable.Columns["Encounter History"].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = encounterDataTable.CurrentCell.RowIndex;

            if (index > -1)
            {    
                Form3 f3 = new Form3();
                f3.getHistory(encounterTable.Rows[index].ItemArray[1].ToString());
                f3.Show();
            }
        }
    }
}
