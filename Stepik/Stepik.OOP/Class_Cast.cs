namespace Stepik.OOP
{
    class ClassA { }

    class ClassB : ClassA { }

    class ClassC : ClassA { }

    class Class_Cast
    {
        static void Entry()
        {
            ClassA a = new ClassA();
            ClassB b = new ClassB();
            ClassC c = new ClassC();

            ClassA d = (ClassA)b;

            ClassA e = (ClassA)d;
        }
    }
}
