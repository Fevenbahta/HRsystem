using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class Step : BaseDomainEntity
    {
        public string Name { get; set; } 
        public bool IsActive { get; set; } 
        public string LevelId { get; set; } 
        public string Amount { get; set; } 
    }
}
