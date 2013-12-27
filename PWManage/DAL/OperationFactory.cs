using System;
using System.Collections.Generic;
using System.Text;
using BLL;

namespace DAL
{
    public class OperationFactory
    {
        public static Operation GetOperation()
        {
            Operation o = null;
            string type = XMLOperation.ConfigueGet("ProgramSet.xml", "DataBase", "Type");
            switch (type)
            {
                case "XML":
                    o= new XMLOperation();
                    break;
            }
            return o;
        }

    }
}
