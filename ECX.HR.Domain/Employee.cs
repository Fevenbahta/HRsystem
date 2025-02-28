using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class Employee : BaseDomainEntity
    {
        public string AdId{ get; set; }
        public string ECXId{ get; set; }
        public string DemographiesId{ get; set; }
        public string EmployeeStatusId{ get; set; }
        public int TINNumber{ get; set; }
        public DateTime EmploymentDate { get; set; }
        public string PositionId{ get; set; }
        public DateTime Desegregation{ get; set; }
        public string PhotoURL{ get; set; }
        public string MortalityStatus{ get; set; }
        public DateTime DeathDate{ get; set; }
        public bool IsActive { get; set; }
    }
}
