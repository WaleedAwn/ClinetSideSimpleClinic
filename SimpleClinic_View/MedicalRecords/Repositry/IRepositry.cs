using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleClinic_View.MedicalRecords.Model;

namespace SimpleClinic_View.MedicalRecords.Repositry
{
    public interface IMedicalRecordRepository<T> : IMedicalRecordRepositoryGetByID<T>, IMedicalRecordRepositoryCRUD<T> where T : class
    {

    }
    public interface IMedicalRecordRepositoryGetByID<T> where T : class
    {
        Task<T> GetByIdAsync(int id);

    }
    public interface IMedicalRecordRepositoryCRUD<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<int> AddAsync(T entity);
        Task<bool> UpdateAsync(int id, T entity);
        Task<bool> DeleteAsync(int id);

    }




}
