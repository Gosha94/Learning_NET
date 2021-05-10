using System.Runtime.InteropServices;

namespace MemoryStructAlloc.Structures
{

    [StructLayoutAttribute(LayoutKind.Explicit)]
    public struct UserType
    {
        [FieldOffset(0)]
        public int x;
        [FieldOffset(0)]
        public int y;
    }
}
