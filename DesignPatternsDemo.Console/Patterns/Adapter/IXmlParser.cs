using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Console.Patterns.Adapter
{
    public interface IXmlParser<T>
    {
        T Parse(string data);
        String ConvertToXml(T obj);
    }
}