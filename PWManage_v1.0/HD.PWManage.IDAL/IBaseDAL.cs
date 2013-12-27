using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HD.PWManage.IDAL
{
    public interface IBaseDAL<T> where T : class,new()
    {
        List<T> GetList();

        void Add(T model);

        void Delete(int id);

        void Update(T model);
    }
}
