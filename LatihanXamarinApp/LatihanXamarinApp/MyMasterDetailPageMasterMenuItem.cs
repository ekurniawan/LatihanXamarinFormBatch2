﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanXamarinApp
{

    public class MyMasterDetailPageMasterMenuItem
    {
        public MyMasterDetailPageMasterMenuItem()
        {
            TargetType = typeof(MyMasterDetailPageMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public Type TargetType { get; set; }
        public string Source { get; set; }
    }
}