using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class Spouse : BaseDomainEntity
    {
        public string DemographiesId{ get; set; }
        public string EmployeeId{ get; set; }
        public string MarriageCertificate{ get; set; }
        public string DivorceCertificate{ get; set; }
        public bool IsActive { get; set; }
    }
}
