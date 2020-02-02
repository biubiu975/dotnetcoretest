using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Demo2
{
    public class AssemblyHelper
    {
        public static Dictionary<Type, Type[]> GetImpleAndInterfaces(string assemblyName,string suffix)
        {
            if (!String.IsNullOrEmpty(assemblyName))
            {
                Assembly assembly = Assembly.Load(assemblyName);
                List<Type> types = assembly
                    .GetTypes()
                    .Where(x => !x.IsInterface && x.Name.Contains(suffix) && !x.IsGenericType)
                    .ToList();
 
                var result = new Dictionary<Type, Type[]>();
                foreach (var item in types)
                {
                    var interfaceType = item.GetInterfaces();
                    result.Add(item, interfaceType);
                }
                return result;
            }
            return new Dictionary<Type, Type[]>();
        }
    }
}