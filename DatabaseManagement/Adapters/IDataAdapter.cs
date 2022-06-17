using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagement {
    public interface IDataAdapter<T>  {
        void AddNewData(T t);
        void SaveExistingData(T t);
    }
}
