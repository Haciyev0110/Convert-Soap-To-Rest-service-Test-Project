﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class FirstTable
    {
        public FirstTable()
        {
            this.Insert_Date = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime Insert_Date { get; set; }
       
    }
}
