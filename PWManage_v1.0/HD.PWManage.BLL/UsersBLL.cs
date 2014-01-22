using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HD.PWManage.DALFactory;
using HD.PWManage.IDAL;
using HD.PWManage.Model;

namespace HD.PWManage.BLL
{
    public class UsersBLL
    {
        IUsersDAL dal = AbstractFactory.CreateUsersDAL();

        /// <summary>
        /// 获得列表
        /// </summary>
        /// <returns></returns>
        public List<Model.Users> GetList()
        {
            List<Users> list = dal.GetList();
            foreach (Users user in list)
            {
                user.Pw = GetPw(user.Pw);
            }
            return list;
        }

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public void Add(Model.Users model)
        {
            dal.Add(model);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public void Update(Model.Users model)
        {
            dal.Update(model);
        }

        public string GetPw(string pw)
        {
            EncryptBLL ebll = new EncryptBLL();
            return ebll.GetDecryptStr(pw);
        }
    }
}
