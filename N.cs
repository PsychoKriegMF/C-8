using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_8
{
    public class N 
    {
        public delegate void MyDelegate(string msg);
        public event MyDelegate OnMsg;

        public static void ShowMsg(string msg)
        {
            Console.WriteLine(msg);
        }

        public void HandleMes(string msg)
        {
            Console.WriteLine(msg);
        }
        public void TakeMsg(string msg)
        {
            OnMsg.Invoke(msg);
        }
    }
}
