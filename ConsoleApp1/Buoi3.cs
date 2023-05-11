using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{

    public struct HocVien
    {
        public string name, gender, uni, abode, home;
        public DateOnly birth;
    }


    public enum SoNgay
    {
        January = 31,
        February = 28,
        March = 31,
        April = 30,
        May = 31,
        June = 30,
        July = 31,
        August = 31,
        September = 30,
        October = 31,
        November = 30,
        December = 31
    }

    
}
