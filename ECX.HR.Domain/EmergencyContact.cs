using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class EmergencyContact : BaseDomainEntity
    {
        public string EmployeeId{ get; set; }
        public string DemographiesId{ get; set; }
        public bool IsActive { get; set; }
    }
}
