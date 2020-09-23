using CZBK.TestProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZBK.TestProject.BLL
{
   public class UserInfoService
    {
       //DAL.UserInfoDal UserInfoDal = new DAL.UserInfoDal();//问题：业务层与数据层紧耦合。
     //  IDAL.IUserInfoDal UserInfoDal = new DAL.UserInfoDal();//变化点。
       IDAL.IUserInfoDal UserInfoDal = DALFactory.FactoryClass.CreateUserInfoDal();
       /// <summary>
       /// 列表
       /// </summary>
       /// <returns></returns>
       public List<UserInfo> GetEntityList()
       {
           return UserInfoDal.GetEntityList();
       }
       /// <summary>
       /// 根据用户的编号返回一条记录
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
       public UserInfo GetModel(int id)
       {
           return UserInfoDal.GetEntityModel(id);
       }
       /// <summary>
       /// 根据用户名找用户
       /// </summary>
       /// <param name="userName"></param>
       /// <returns></returns>
       public UserInfo GetModel(string userName)
       {
           return UserInfoDal.GetUserInfoModel(userName);
       }
       /// <summary>
       /// 删除
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
       public bool DeleteEntity(int id)
       {
           return UserInfoDal.DeleteEntityModel(id)>0;
       }
       /// <summary>
       /// 插入
       /// </summary>
       /// <param name="userInfo"></param>
       /// <returns></returns>
       public bool InsertEntity(UserInfo userInfo)
       {
           return UserInfoDal.InsertEntityModel(userInfo)>0;
       }
       /// <summary>
       /// 更新
       /// </summary>
       /// <param name="userInfo"></param>
       /// <returns></returns>
       public bool UpdateEntity(UserInfo userInfo)
       {
           return UserInfoDal.UpdateEntityModel(userInfo)>0;
       }
       /// <summary>
       /// 获取分页数据
       /// </summary>
       /// <param name="pageIndex">当前页码</param>
       /// <param name="pageSize">每页显示记录数</param>
       /// <returns></returns>
       public List<UserInfo> GetPageEntityList(int pageIndex,int pageSize)
       {
           int start = (pageIndex - 1) * pageSize + 1;
           int end = pageIndex * pageSize;
          return UserInfoDal.GetPageEntityList(start, end);
       }
       /// <summary>
       /// 计算总的页数
       /// </summary>
       /// <param name="pageSize">每页显示记录数</param>
       /// <returns></returns>
       public int GetPageCount(int pageSize)
       {
           int recordCount = UserInfoDal.GetRecordCount();//获取总的记录数.
           int pageCount =Convert.ToInt32(Math.Ceiling((double)recordCount / pageSize));
           return pageCount;
       }

       /// <summary>
       /// 校验用户信息
       /// </summary>
       /// <param name="userName"></param>
       /// <param name="userPwd"></param>
       /// <returns></returns>
       public bool CheckUserInfo(string userName, string userPwd,out string msg,out UserInfo userInfo)
       {
           bool isSuccess = false;
           userInfo= UserInfoDal.GetUserInfoModel(userName);
          if (userInfo != null)
          {
              if (userInfo.UserPass == userPwd)
              {
                  isSuccess = true;
              }
          }
          if (isSuccess)
          {
              msg = "登录成功!!";
          }
          else
          {
              msg = "用户名密码错误!!";
           
          }
          return isSuccess;
       }


    }
}
