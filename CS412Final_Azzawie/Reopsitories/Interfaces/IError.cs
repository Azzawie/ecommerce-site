using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Azzawie.Reopsitories.Interfaces
{
    public interface IError
    {
        bool Log(Exception ex);
    }
}