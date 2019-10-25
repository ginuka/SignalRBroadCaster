using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBroadCasterDB.HubLib.Model
{
    public class HubResponseModel
    {
        public string EmpId { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}
