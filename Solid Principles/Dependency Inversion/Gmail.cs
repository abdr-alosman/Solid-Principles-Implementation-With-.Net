using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.Dependency_Inversion
{
    public class Gmail1 : IMessage
    {
        public string Addrees = "address";
        public string from = "from mail";
        public string ToAddress = "ToAddress";

        public void Send() { /* code */}
    }
    public class Hotmail1 : IMessage
    {
        public string Addrees = "address";
        public string from = "from mail";
        public string ToAddress = "ToAddress";
        public void Send() { /* code */}
    }

    public class WebMail : IMessage
    {
        public string Addrees = "address";
        public string from = "from mail";
        public string ToAddress = "ToAddress";
        public void Send() { /* code */}
    }
}
