﻿namespace NumericIntPtr_Core_App;

public class Code1
{
    private IntPtr constField = new(1);

    public class Class1
    {
        private IntPtr constField;

        public Class1()
        {
            constField = (IntPtr)2;

            long t = constField;
        }
    }
}