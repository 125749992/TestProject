using CZBK.TestProject.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace CZBK.TestProject.DAL
{
    public class UserInfoDal:IDAL.IUserInfoDal
    {
        /// <summary>
        /// 返回列表
        /// </summary>
        /// <returns></returns>
        public List<UserInfo> GetEntityList()
        {
            string sql = "select * from UserInfo";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text);
            List<UserInfo> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<UserInfo>();
                UserInfo userInfo = null;
                foreach (DataRow row in da.Rows)
                {
                    userInfo = new UserInfo();
                    LoadEntity(row, userInfo);
                    list.Add(userInfo);
                }
            }
            return list;
        }
        public void LoadEntity(DataRow row, UserInfo userInfo)
        {
            userInfo.ID = Convert.ToInt32(row["ID"]);
            userInfo.UserName = row["UserName"] != DBNull.Value ? row["UserName"].ToString() : string.Empty;
            userInfo.UserPass = row["UserPass"] != DBNull.Value ? row["UserPass"].ToString() : string.Empty;
            userInfo.Email = row["Email"] != DBNull.Value ? row["Email"].ToString() : string.Empty;
            userInfo.RegTime = Convert.ToDateTime(row["RegTime"]);
        }
        /// <summary>
        /// 返回一条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserInfo GetEntityModel(int id)
        {
            string sql = "select * from UserInfo where ID=@ID";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, new SqlParameter("@ID", id));
            UserInfo userInfo = null;
            if (da.Rows.Count > 0)
            {
                userInfo = new UserInfo();
                LoadEntity(da.Rows[0], userInfo);
            }
            return userInfo;
        }
        /// <summary>
        /// 删除一条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteEntityModel(int id)
        {
            string sql = "delete from UserInfo where ID=@ID";
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, new SqlParameter("@ID", id));
        }
        /// <summary>
        /// 插入一条记录
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public int InsertEntityModel(UserInfo userInfo)
        {
            string sql = "insert into UserInfo(UserName,UserPass,Email,RegTime) values(@UserName,@UserPass,@Email,@RegTime)";
            SqlParameter[] pars = { 
                                 new SqlParameter("@UserName",SqlDbType.NVarChar,32),
                                 new SqlParameter("@UserPass",SqlDbType.NVarChar,32),
                                   new SqlParameter("@Email",SqlDbType.NVarChar,32),
                                   new SqlParameter("@RegTime",SqlDbType.DateTime)
                                 };
            pars[0].Value = userInfo.UserName;
            pars[1].Value = userInfo.UserPass;
            pars[2].Value = userInfo.Email;
            pars[3].Value = userInfo.RegTime;
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }
        /// <summary>
        /// 更新一条记录
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public int UpdateEntityModel(UserInfo userInfo)
        {
            string sql = "update UserInfo set UserName=@UserName,UserPass=@UserPass,Email=@Email,RegTime=@RegTime where ID=@ID";
            SqlParameter[] pars = { 
                                 new SqlParameter("@UserName",SqlDbType.NVarChar,32),
                                 new SqlParameter("@UserPass",SqlDbType.NVarChar,32),
                                   new SqlParameter("@Email",SqlDbType.NVarChar,32),
                                   new SqlParameter("@RegTime",SqlDbType.DateTime),
                                     new SqlParameter("@ID",SqlDbType.Int,4)
                                 };
            pars[0].Value = userInfo.UserName;
            pars[1].Value = userInfo.UserPass;
            pars[2].Value = userInfo.Email;
            pars[3].Value = userInfo.RegTime;
            pars[4].Value = userInfo.ID;
           return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pars);
        }

        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="start">起始位置</param>
        /// <param name="end">终止位置</param>
        /// <returns></returns>
        public List<UserInfo> GetPageEntityList(int start, int end)
        {
            //select top
            string sql = "select * from(select row_number() over(order  by id) as num,* from UserInfo) as t where t.num>=@start and t.num<=@end";
            SqlParameter[] pars = { 
                                  new SqlParameter("@start",start),
                                  new SqlParameter("@end",end)
                                  };
           DataTable da= SqlHelper.GetTable(sql, CommandType.Text, pars);
           List<UserInfo> list = null;
           if (da.Rows.Count > 0)
           {
               list = new List<UserInfo>();
               UserInfo userInfo = null;
               foreach (DataRow row in da.Rows)
               {
                   userInfo = new UserInfo();
                   LoadEntity(row, userInfo);
                   list.Add(userInfo);
               }
           }
           return list;
        }
        /// <summary>
        /// 总的记录数.
        /// </summary>
        /// <returns></returns>
        public int GetRecordCount()
        {
            string sql = "select count(*) from UserInfo";
           return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text));
        }

        //public UserInfo GetUserInfoModel(string userName, string userPwd)
        //{
        //    string sql = "select * from UserInfo where UserName=@UserName and UserPass=@UserPass";
        //    SqlParameter[] pars = { 
        //                          new SqlParameter("@UserName",userName),
        //                          new SqlParameter("@UserPass",userPwd)
        //                          };
        //    DataTable da = SqlHelper.GetTable(sql, CommandType.Text,pars);
        //    UserInfo userInfo = null;
        //    if (da.Rows.Count > 0)
        //    {
        //        userInfo = new UserInfo();
        //        LoadEntity(da.Rows[0], userInfo);
        //    }
        //    return userInfo;
        //}

        public UserInfo GetUserInfoModel(string userName)
        {
            string sql = "select * from UserInfo where UserName=@UserName";
            SqlParameter[] pars = { 
                                  new SqlParameter("@UserName",userName)
                                 
                                  };
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            UserInfo userInfo = null;
            if (da.Rows.Count > 0)
            {
                userInfo = new UserInfo();
                LoadEntity(da.Rows[0], userInfo);
            }
            return userInfo;
        }
    }
}
