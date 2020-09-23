using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZBK.TestProject.DALFactory
{
    /// <summary>
    /// 工厂模式（工厂类）封装了对象的创建
    /// </summary>
   public class FactoryClass
    {
       public static IDAL.IUserInfoDal CreateUserInfoDal()
       {
        
           return new DAL.UserInfoDal();
       }
    
    }
}
