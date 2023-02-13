using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace _13022023home
{
    internal class Group
    {

        string _no;
        double _avgpoint;
        double _Points;
        double _count;
        public string No
        {
            get
            {
                return _no;
            }
            set
            {
                if (value.Length <= 4 && char.IsUpper(value[0]))
                {
                    _no = value;
                }
                else
                {
                    Console.WriteLine("Yazilisda sehv var");
                }

            }
        }
        
        public double AvgPoint
        {
            get
            {
                return _avgpoint;
            }
            set
            {
                if (value >= 0)
                {
                    value = _Points / _count;
                    _avgpoint = value;
                }
            }
        }
        
    }
}
