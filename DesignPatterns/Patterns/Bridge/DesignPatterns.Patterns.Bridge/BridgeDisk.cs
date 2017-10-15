using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Bridge
{
    public class BridgeDisk
    {
        public static void Main()
        {
            Stack[] stacks = { new Stack("array"), new Stack("list"), new StackFIFO(), new StackHanoi() };

            for (int i = 1; i < 15; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    stacks[j].Push(i);
                }
            }

            Random random = new Random();
            for (int i = 1; i < 15; i++)
            {
                stacks[3].Push(random.Next(20));
            }

            for (int i = 0; i < stacks.Length; i++)
            {
                while (!stacks[i].IsEmpty())
                {
                    Debug.WriteLine(stacks[i].Pop() + " ");
                }
            }
            Debug.WriteLine("total rejected is " + ((StackHanoi)stacks[3]).ReportRejected());
        }
    }
}
