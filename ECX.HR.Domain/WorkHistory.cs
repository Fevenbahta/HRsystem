using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class WorkHistory : BaseDomainEntity
    {
        public string EmployeeId{ get; set; }
        public string OrganizationName{ get; set; }
        public string Position{ get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}