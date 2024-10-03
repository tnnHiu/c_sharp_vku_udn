using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6.Exercise_2
{

    public class MyEventArgs : EventArgs
    {
        public MyEventArgs(string data)
        {
            Data = data;
        }
        public string Data { get; set; }
    }


    public class ClassA
    {
        public event EventHandler? EventNews1;
        public void Send()
        {
            EventNews1?.Invoke(this, new MyEventArgs("Có tin tức mới Abc..."));
        }
    }

    public class ClassB
    {
        public void Sub(ClassA p)
        {
            p.EventNews1 += ReceiverFromPublisher!;
        }

        private void ReceiverFromPublisher(object sender, EventArgs e)
        {

            MyEventArgs eventArgs = (MyEventArgs)e;
            Console.WriteLine("ClassB: " + eventArgs.Data);
        }
    }

    public class ClassC
    {
        public void Sub(ClassA p)
        {
            p.EventNews1 += ReceiverFromPublisher!;
        }

        private void ReceiverFromPublisher(object sender, EventArgs e)
        {
            MyEventArgs eventArgs = (MyEventArgs)e;
            Console.WriteLine("ClassC: " + eventArgs.Data);
        }
    }

    public class Program2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ClassA p = new ClassA();
            ClassB sa = new ClassB();
            ClassC sb = new ClassC();

            sa.Sub(p);
            sb.Sub(p);

            p.Send();
        }
    }
}
