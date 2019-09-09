using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRandomizer
{
    class RiyaziHesablama : IMathematic, IShowResult
    {
        public int Add(int a, int b)
        {
            return a * 10 + b * 10;
        }


        public int Divide(int a, int b)
        {
            return a / 10 + b / 10;
        }

        public int Multiply(int a, int b)
        {
            return (a * 10) *  (b * 10);
        }

        public int Substract(int a, int b)
        {
            return (a * 10) - (b * 10);
        }


        public void Display(int a)
        {
            System.Windows.Forms.MessageBox.Show($" Result ={a}");
        }
    }
}
