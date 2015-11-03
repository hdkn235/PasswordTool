using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HD.PWManage.Model;
using System.Data;

namespace HD.PWManage.IDAL
{
    public interface IAccountInfoDAL:IBaseDAL<AccountInfo>
    {
        int GetRecordCount(string strWhere);

        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
    }
}
