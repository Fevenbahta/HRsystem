using AutoMapper;
using ECX.HR.Application.CQRS.Departments.Request.Command;
using ECX.HR.Application.Exceptions;
using ECX.HR.Application.Contracts.Persistent;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Departments.Handler.Command
{
    public class DeleteDepartmentCommandHandler : IRequestHandler<DeleteDepartmentCommand>
    {
        private IDepartmentRepository _departmentRepository;
        private IMapper _mapper;
        public DeleteDepartmentCommandHandler(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = await _departmentRepository.GetById(request.Id);
            await _departmentRepository.Delete(department);
            return Unit.Value;
        }

        async Task IRequestHandler<DeleteDepartmentCommand>.Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = await _departmentRepository.GetById(request.Id);
            if(department == null) 
                throw new NotFoundException(nameof(department), request.Id);
            await _departmentRepository.Delete(department);
        }
    }
}
