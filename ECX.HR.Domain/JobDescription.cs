using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class JobDescription : BaseDomainEntity
    {
        public string Description { get; set; }
        public string PositionTypeId { get; set; }
        public string PositionId { get; set; }
        public bool IsActive { get; set; }
    }
}
