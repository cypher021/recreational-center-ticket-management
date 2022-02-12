using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Coursework
{
    public class Visitor
    {
        public Visitor()
        {

        }
        public string ID { get; set; }
        public string Data { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Group_Number { get; set; }
        public string In_Time { get; set; }
        public string Out_Time { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public int TotalVisitors { get; internal set; }
 }
}