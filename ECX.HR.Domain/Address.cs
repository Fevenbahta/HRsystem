using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class Address : BaseDomainEntity
    {
        public string OwnerId { get; set; }
        public string AddressType { get; set; }
        public bool IsActive { get; set; }
        public string AddressValue { get; set; }
    }
}
