using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClinic_View.MedicalRecords.Repositry
{
    public interface IMedicalRecordRepository<T> where T : class
        {
            Task<IEnumerable<T>> GetAllAsync();
            Task<T?> GetByIdAsync(int id);
            Task<bool> AddAsync(T entity);
            Task<bool> UpdateAsync(int id,T entity);
            Task<bool> DeleteAsync(int id);
        }

    
}
