using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DelegateEvents.Arithmetic;
using static DelegateEvents.Student;

namespace DelegateEvents
{
    public partial class Form1 : Form
    {
        Student student;
        AverageLessThanFiftyDelegate averageLess;
        public Form1()
        {
            InitializeComponent();
            student = new Student
            {
                Name = "Gunel"
            };

            averageLess = new AverageLessThanFiftyDelegate(SendEmail);
            averageLess += SendSms;
            averageLess += AtasinaDe;


            student.PisTelebeEvent += averageLess;

            //Test();
        }


        public void Test()
        {
            Arithmetic a = new Arithmetic();
            ArithmeticDelegate arithmeticDelegate = new ArithmeticDelegate(a.Add);
            arithmeticDelegate += a.Div;
            arithmeticDelegate += a.Mul;
            arithmeticDelegate += a.Sub;

            arithmeticDelegate(100, 20);


            arithmeticDelegate -= a.Div;
            arithmeticDelegate(200, 50);

        }





        private void Button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtScore.Text);
            int aver = student.AddScore(a);
            lblAverageScore.Text = aver.ToString();

            txtScore.Text = "";
        }

        public void SendEmail(Student student)
        {
            MessageBox.Show($"{student.Name} score is less than 50. Email sended");
        }
        public void SendSms(Student student)
        {
            MessageBox.Show($"{student.Name} score is less than 50. SMS sended");
        }
        public void AtasinaDe(Student student)
        {
            MessageBox.Show($"{student.Name} score is less than 50. Atasina melumat verildi");
        }
    }
}
