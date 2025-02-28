using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class Education : BaseDomainEntity
    {
        public string Name{ get; set; }
        public string EmployeeId{ get; set; }
        public string EducationLevelId{ get; set; }
        public bool IsActive { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}