using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLib.Abstractions
{
    public interface IRepositoryEmployee<T>
    {
        IEnumerable<T> GetEmployees();
        void AddEmployee(T employee);
        void ModifyEmployee(T employee);
        void RemoveEmployee(int id);
    }
}
