﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.App.Interfaces
{
    public interface IListForm
    {
        void InsertRecord();
        void UpdateRecord();
        void DeleteRecord();
        void SearchRecords(string text);
        void RefreshRecords();
    }
}
