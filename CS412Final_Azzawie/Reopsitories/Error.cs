using CS412Final_Azzawie.Reopsitories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Azzawie.Reopsitories
{
    public class Error : IError
    {
        public bool Log(Exception ex)
        {
            return false;
        }
    }
}