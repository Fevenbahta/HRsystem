using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class PositionType : BaseDomainEntity
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}