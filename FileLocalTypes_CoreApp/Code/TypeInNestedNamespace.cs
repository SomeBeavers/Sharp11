namespace FileLocalTypes_CoreApp.Code1
{
    public class TypeInNestedNamespace
    {
    
    }

    file class DuplicatedClass
    {
        
    }

    namespace MyNamespace
    {
        class DuplicatedClass
        {
            public DuplicatedClass(string s)
            {

            }
        }

        class UseDuplicatedClass
        {
            public void Test()
            {
                new DuplicatedClass("");
                new DuplicatedClass("");
            }
        }
    }
}

