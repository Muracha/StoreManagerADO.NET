using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreManager.Models;
using StoreManager.Repositories;
using StoreManager.Services;

namespace StoreManager.App.ListForm
{
    public partial class UserListTest : ListBaseForm<UserDetails, User, UserRepository, UserService>
    {
        public UserListTest()
        {
            
        }
    }
}
