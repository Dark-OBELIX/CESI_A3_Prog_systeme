using System;

namespace workshop
{
    public class MyClass
    {
        public delegate int Callback(int v1, int v2);

        public static int MethodeRetour(int v1, int v2)
        {
            return v1 + v2;
        }
    }
}
