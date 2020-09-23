using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZBK.TestProject.AccessDAL
{
   public class UserInfoDal:IDAL.IUserInfoDal
    {
        public List<Model.UserInfo> GetEntityList()
        {
            throw new NotImplementedException();
        }

        public void LoadEntity(System.Data.DataRow row, Model.UserInfo userInfo)
        {
            throw new NotImplementedException();
        }

        public Model.UserInfo GetEntityModel(int id)
        {
            throw new NotImplementedException();
        }

        public int DeleteEntityModel(int id)
        {
            throw new NotImplementedException();
        }

        public int InsertEntityModel(Model.UserInfo userInfo)
        {
            throw new NotImplementedException();
        }

        public int UpdateEntityModel(Model.UserInfo userInfo)
        {
            throw new NotImplementedException();
        }


        public List<Model.UserInfo> GetPageEntityList(int start, int end)
        {
            throw new NotImplementedException();
        }

        public int GetRecordCount()
        {
            throw new NotImplementedException();
        }


        public Model.UserInfo GetUserInfoModel(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
