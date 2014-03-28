using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teacher.Data;

namespace Teacher.Interfaces
{
    abstract class AStatistic
    {
        private DateTime missing;
        private bool homeworkdone;
        private bool wellworked;
        private bool badworked;
        private Notiz msg;
    }
}
