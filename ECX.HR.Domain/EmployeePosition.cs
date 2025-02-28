using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class EmployeePosition : BaseDomainEntity
    {
        public string EmployeeId{ get; set; }
        public string PositionId{ get; set; }
        public string PositionTypeId{ get; set; }
        public string StepId{ get; set; }
        public string FirstSupervisorId{ get; set; }
        public string SecondSupervisorId{ get; set; }
        public string LocationId{ get; set; }
        public string DepartmentId{ get; set; }
        public string DivisionId{ get; set; }
        public bool IsActive{ get; set; }
        
    }
}
