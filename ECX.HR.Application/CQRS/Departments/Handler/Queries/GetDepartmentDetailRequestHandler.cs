using AutoMapper;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.Departments.Request.Queries;
using ECX.HR.Application.DTOs.Department;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Departments.Handler.Queries
{
    public class GetDepartmentDetailRequestHandler : IRequestHandler<GetDepartmentDetailRequest, DepartmentDto>
    {
        private IDepartmentRepository _departmentRepository;
        private IMapper _mapper;
        public GetDepartmentDetailRequestHandler(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }
        public async Task<DepartmentDto> Handle(GetDepartmentDetailRequest request, CancellationToken cancellationToken)
        {
            var department =await _departmentRepository.GetById(request.Id);
            return _mapper.Map<DepartmentDto>(request);
        }
    }
}
