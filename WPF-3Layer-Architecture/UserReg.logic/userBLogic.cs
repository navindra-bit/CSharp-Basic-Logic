﻿using UserReg.Data;
using Microsoft.Data.SqlClient;
using System.Data;
namespace UserReg.logic
{
    public class userBLogic
    {
        private bool IsVaild(string name, string age)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }
            if (string.IsNullOrEmpty(age))
            {
                return false;
            }
            if (!int.TryParse(age, out var id))
            {
                return false;
            }
            if (id < 18 || id > 100)
            {
                return false;
            }

            return true;
        }


        public int Interdata(string name, string age)
        {
            if (IsVaild(name, age) == true)
            {
                UseData data = new UseData();
                return data.inserData(name, age);
            }
            return -1;
        }
        public DataSet GetDataset()
        {
            UseData useData = new UseData();
            return useData.GetDataValue();
        }

        public int UpdateData(string name, string age,string userid)
        {
            if (IsVaild(name, age) == true)
            {
                UseData data = new UseData();
                return data.UpdateNewData(name, age, userid);
            }
            return -1;
        }
    }
}