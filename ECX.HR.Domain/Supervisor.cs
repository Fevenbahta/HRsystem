using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class Supervisor : BaseDomainEntity

    {
        public string AdId { get; set; }
        public bool IsFirstSupervisorId{ get; set; }
        public bool IsSecondSupervisorId{ get; set; } 
    }
}
