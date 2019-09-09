using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvents
{
    public class Student
    {

        public delegate void AverageLessThanFiftyDelegate(Student student);
        public event AverageLessThanFiftyDelegate PisTelebeEvent;


        public string Name { get; set; }
        public List<int> Scores { get; set; }

        public Student()
        {
            Scores = new List<int>();
        }

        public int AddScore(int score)
        {
            int average = 0;

            Scores.Add(score);

            foreach (int item in Scores)
            {
                average += item;
            }

            average = average / Scores.Count;

            if (average < 50)
            {
                if (PisTelebeEvent !=null)
                {
                    PisTelebeEvent(this);
                }
            }

            return average;
        }


    }
}
