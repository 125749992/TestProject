using CZBK.TestProject.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZBK.TestProject.IDAL
{
   public interface IUserInfoDal
    {
       List<UserInfo> GetEntityList();
       void LoadEntity(DataRow row, UserInfo userInfo);
       UserInfo GetEntityModel(int id);
       int DeleteEntityModel(int id);
       int InsertEntityModel(UserInfo userInfo);
       int UpdateEntityModel(UserInfo userInfo);
       List<UserInfo> GetPageEntityList(int start,int end);
       int GetRecordCount();
       UserInfo GetUserInfoModel(string userName);
    }
}
