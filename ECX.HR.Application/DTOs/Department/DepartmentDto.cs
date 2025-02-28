using ECX.HR.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.Department
{
    public class DepartmentDto : BaseDtos
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string IsActive { get; set; }
    }
}
