using DataHelper;
using StoreManager.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StoreManager.Repositories
{
    public class ContactInfoRepository : RepositoryBase<ContactInfo>
    {
        public ContactInfoRepository(string commandText = null) 
        {
            _commandText = commandText;
        }

    }
}
