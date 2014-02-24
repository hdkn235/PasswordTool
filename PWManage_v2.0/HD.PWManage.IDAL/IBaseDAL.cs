using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HD.PWManage.IDAL
{
    public interface IBaseDAL<T> where T : class,new()
    {
        DataSet GetList(string strWhere);

        bool Add(T model);

        bool Delete(int id);

        bool Update(T model);

        bool Exists(int ID);

        bool DeleteList(string IDlist);

        T GetModel(int ID);

        T DataRowToModel(DataRow row);

        int GetRecordCount(string strWhere);

        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
    }
}
