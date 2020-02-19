using System;
using System.Runtime.Serialization;

namespace AlloeHRMSystem.ApplicationServices.EmployeeService.Commands.DeleteEmployee
{
    
    public class NotFoundException : Exception
    {
        public NotFoundException(string name, object key)
            : base($"Entity \"{name}\" ({key}) was not found.")
        {

        }
    }
}