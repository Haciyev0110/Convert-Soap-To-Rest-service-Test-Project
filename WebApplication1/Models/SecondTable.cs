using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class SecondTable
    {
        public SecondTable()
        {

        }
        public SecondTable(int parentId,string val)
        {
            FirstTableId = parentId;
            Value = val;
            Insert_Date = DateTime.Now;
        }


        public int Id { get; set; }
        public DateTime Insert_Date { get; set; }
        public FirstTable FirstTable { get; set; }
        public int FirstTableId { get; set; }
        public string Value { get; set; }
    }
}
