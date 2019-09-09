using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateEvents
{

    class Arithmetic
    {

        public delegate void ArithmeticDelegate(int a, int b);

        public void Add(int a, int b)
        {
            MessageBox.Show($"Result: {a + b}");
        }
        public void Sub(int a, int b)
        {
            MessageBox.Show($"Result: {a - b}");

        }
        public void Mul(int a, int b)
        {
            MessageBox.Show($"Result: {a * b}");

        }
        public void Div(int a, int b)
        {
            MessageBox.Show($"Result: {a / b}");

        }
    }
}
