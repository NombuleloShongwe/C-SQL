using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbStudents1DataSet.tbStudents1' table. You can move, or remove it, as needed.
            this.tbStudents1TableAdapter.Fill(this.dbStudents1DataSet.tbStudents1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbStudents1BindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbStudents1BindingSource.EndEdit();
            tbStudents1TableAdapter.Update(dbStudents1DataSet.tbStudents1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbStudents1BindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbStudents1BindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbStudents1BindingSource.MovePrevious();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tbStudents1BindingSource.MoveNext();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
