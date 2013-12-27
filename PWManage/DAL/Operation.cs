using System;
using System.Collections.Generic;
using System.Text;
using BLL;

namespace DAL
{
    abstract public class Operation
    {
        protected string path = "DataFile.xml";

        public UserInfoEntity userInfo = new UserInfoEntity();

        public abstract void Insert();

        public abstract void Update();

        public abstract void Search();

        public abstract void Del();
    }
}
