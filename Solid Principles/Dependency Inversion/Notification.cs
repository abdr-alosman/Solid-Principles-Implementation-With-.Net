using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.Dependency_Inversion
{
    public class Notification1
    {
        private IMessage _mailService;
        public Notification1(IMessage mailService)
        {
            _mailService = mailService;
        }
        public IMessage mailType { get; set; }

        public void SendMail() { mailType.Send(); }
    }
}
