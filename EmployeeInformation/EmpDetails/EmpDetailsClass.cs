﻿using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDetails
{
    public class EmpDetailsClass : TableEntity
    {
        public EmpDetailsClass()
        {
        }

        public EmpDetailsClass(int empId, string company)
        {
            this.RowKey = empId.ToString();
            this.PartitionKey = company;
        }

        public string EmpName { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string ProfileImage { get; set; }
    }
}
