using System;

namespace Parameters
{
    class Pass
    {
        public static void Refrence(WrappedInt param)
        {
            param.Number = 42;
        }
        public static void Value(int param)
        {
            param = 42;
        }
    }
}
