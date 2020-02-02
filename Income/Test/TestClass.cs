using System;

namespace Demo2.Test
{
    public class TestClass
    {
//        [TestMethod]
        public void BatchDITestMethod()
        {
            var accessImpleAndInterfaces= AssemblyHelper.GetImpleAndInterfaces("DJMS.DataAccess","Access");
            foreach(var v in accessImpleAndInterfaces)
            {
                Console.WriteLine($"class={v.Key},interface={v.Value[0]},{v.Value.Length}");
            }
            Console.WriteLine($"Access接口及实现个数为：{accessImpleAndInterfaces.Count}");
 
            var logicImpleAndInterfaces = AssemblyHelper.GetImpleAndInterfaces("DJMS.BusinessLogic", "Logic");
            foreach (var v in logicImpleAndInterfaces)
            {
                Console.WriteLine($"class={v.Key},interface={v.Value[0]},{v.Value.Length}");
            }
            Console.WriteLine($"Logic接口及实现个数为：{accessImpleAndInterfaces.Count}");
        }
    }
}