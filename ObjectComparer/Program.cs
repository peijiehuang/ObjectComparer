using System.Text;

namespace ObjectComparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short a = 1;
            int b = 1;

            object objA = a; // 装箱
            object objB = b; // 装箱

            Console.WriteLine(a == b); // 比较值输出: true
            Console.WriteLine(objA == objB); // 比较引用地址输出: False



            string str1 = "hello world"; // 字符串字面量
            string str2 = string.Concat("hello", " world"); // 动态拼接

            Console.WriteLine(str1 == str2); // True，值相等
            Console.WriteLine(object.ReferenceEquals(str1, str2)); // False，引用不同

            // 使用装箱后比较
            object obj1 = str1;
            object obj2 = str2;

            Console.WriteLine(obj1 == obj2); // False，引用不同
            Console.WriteLine(obj1.Equals(obj2)); // True，值相等

            // 动态生成的字符串
            StringBuilder sb = new StringBuilder();
            sb.Append("hello").Append(" world");
            string str3 = sb.ToString();

            Console.WriteLine(str1 == str3); // True，值相等
            Console.WriteLine(object.ReferenceEquals(str1, str3)); // False，引用不同

            Console.ReadKey();
        }
    }
}
