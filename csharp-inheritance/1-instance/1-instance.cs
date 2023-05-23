using System;
using System.Collections.Generic;

class Obj
{
    public static bool IsInstanceOfArray(object obj)
    {
        if(obj != null && obj.GetType().IsArray)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}