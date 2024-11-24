using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class UserInputProcessor : IDataProcessor
{
    public string Process(string data)
    {
        return data == null? null : data.ToUpper();
    }
}