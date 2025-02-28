using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class Division : BaseDomainEntity
    {
        public string Name { get; set; }
        public string DepartmentId { get; set; }
        public bool IsActive { get; set; }
    }
}
