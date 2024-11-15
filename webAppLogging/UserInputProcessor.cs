using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class UserInputProcessor : IDataProcessor
{
    public string ProcessData(string input)
    {
        return input.ToUpper();
    }
}