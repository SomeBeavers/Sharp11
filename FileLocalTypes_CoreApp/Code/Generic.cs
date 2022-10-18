using FileLocalTypes_CoreApp.Code;
using FileLocalTypes_CoreApp.Code111;

namespace FileLocalTypes_CoreApp.Code
{
    file class Generic<T>
    {
        private void GenericMethod<U>() where U : class
        {
            const int file = 1;
            Console.WriteLine(file);
        }

        public void UseGenericMethod()
        {
            GenericMethod<AnotherFileType>();
            GenericMethod<AnotherFileType2>();
        }

        private class AnotherFileType
        {
        }
    }

    internal class AnotherFileType2
    {
    }
}

namespace MyNamespace
{
    file class UseGeneric<T> 
        //where T : Generic<int>
    {
        public void Test(T genericParameter)
        {
            var generics = new List<T> { genericParameter };
        }
    }
}

namespace FileLocalTypes_CoreApp.Code111
{
    file class Generic<T>
    {
        private void GenericMethod<U>() where U : class
        {
            const int file = 1;
            Console.WriteLine(file);
        }

        public void UseGenericMethod()
        {
            GenericMethod<AnotherFileType>();
            GenericMethod<AnotherFileType2>();
        }

        private class AnotherFileType
        {
        }
    }

    internal class AnotherFileType2
    {
    }
}