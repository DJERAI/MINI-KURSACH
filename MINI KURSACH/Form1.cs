using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MINI_KURSACH
{
    public partial class Form1 : Form
    {
        
        class connectBD
        {
            public static MySqlConnection ConnDB()
            {
                string connStr = "server=chuc.caseum.ru;port=33333;user=st_1_19_22;database=is_1_19_st22_KURS;password=35131764;";
                MySqlConnection conn = new MySqlConnection(connStr);
                return conn;
            }
        }

        class People
        {
            public int age;
            public int number;
            public string fio;

            public People(int Age, int Number, string Fio)
            {
                age = Age;
                number = Number;
                fio = Fio;
            }
            
            public int AGA
            {
                get { return age; }
                set { age = value; }
            }
            
            public int NUMB
            {
                get { return number; }
                set { number = value; }
            }
           

            public string FIO
            {
                get { return fio; }
                set { fio = value; }
            }
        }
        //class Driver : People
        //{
            
        //}

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}
