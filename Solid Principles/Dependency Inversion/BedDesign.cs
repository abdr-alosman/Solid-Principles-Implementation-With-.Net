using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.Dependency_Inversion
{
    // Bad and Wrong Design
    public class Notification
    {
        private Gmail _gmail=new Gmail();
        private Hotmail _hotmail=new Hotmail();
        public void SendGmail() { _gmail.Send(); }
        public void SendHotmail() { _hotmail.Send(); }

    }
    public class Gmail
    {
        public string Adress { get; set; }
        public string From { get; set; }
        public string ToAdress { get; set; }
        public void Send() { /*code*/}

    }
    public class Hotmail
    {
        public string Adress { get; set; }
        public string From { get; set; }
        public string ToAdress { get; set; }
        public void Send() { /*code*/}
    }
}
