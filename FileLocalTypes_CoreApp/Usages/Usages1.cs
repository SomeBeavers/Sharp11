using static file.A1;
namespace MyNamespace123
{
    file class UsedFileClass
    {
    }
}

namespace MyNamespace2
{
    file class Usages1
    {
        public void Test()
        {
            var usedFileClass = new MyNamespace123.UsedFileClass();
        }
    }
}