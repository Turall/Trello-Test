using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    interface ITasks
    {
        int TaskID { get; set; }
        void AddTask(IBorders border,ITasks task);
        void RemoveTask(IBorders border, ITasks task);
        void UpdateTask(IBorders border, ITasks task);
    }
}
