using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository
    {
        public List<UserModel> GetAllUserDetails()
        {
            var userModelList = new List<UserModel>();
            var userModel = new UserModel();
            userModel.Name = "Thirunavukkarasu";
            userModel.Email = "thirunavukkarasu@outlook.com";
            userModel.Year = "2017-18";
            userModel.Position = "President";
            userModelList.Add(userModel);

            //userModel = new UserModel();
            //userModel.Name = "";
            //userModel.Email = "";
            //userModel.Year = "2017-18";
            //userModelList.Add(userModel);

            return userModelList;
        }
    }
}
