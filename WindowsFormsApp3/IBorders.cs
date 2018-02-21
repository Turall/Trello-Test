using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    interface IBorders
    {
        int BorderID { get; set; }
        void AddBorder();
        void RemoveBorder();
    }
}
