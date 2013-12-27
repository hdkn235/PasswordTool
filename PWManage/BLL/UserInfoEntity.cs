using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class UserInfoEntity
    {
        #region  属性
        private string key;

        public string Key
        {
            get { return key; }
            set { key = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string pw;

        public string Pw
        {
            get { return pw; }
            set { pw = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private int id = 0;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        #endregion
    }
}
