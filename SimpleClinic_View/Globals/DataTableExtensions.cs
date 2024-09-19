using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClinic_View.Globals
{
    public static class DataTableExtensions
    {
        public static DataTable ToDataTable<T>(this IEnumerable<T> data)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            // Get all the properties of the class (T)
            PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            // Create columns in the DataTable for each property
            foreach (var prop in properties)
            {
                // If the property is a Nullable<T>, use its underlying type
                var propertyType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                dataTable.Columns.Add(prop.Name, propertyType);
            }

            // Iterate over the IEnumerable<T> and add rows to the DataTable
            foreach (T item in data)
            {
                var values = new object[properties.Length];
                for (int i = 0; i < properties.Length; i++)
                {
                    var value = properties[i].GetValue(item, null);

                    // If the property is null (for Nullable<T>), set the value to DBNull
                    values[i] = value ?? DBNull.Value;
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }
    }
}
