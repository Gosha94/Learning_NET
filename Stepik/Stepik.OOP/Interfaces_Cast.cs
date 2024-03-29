﻿using System;

namespace Stepik.OOP
{

    interface IUser
    {
        void Method();
    }

    interface IAdmin
    {
    }

    class User : IUser
    {
        public void Method() { }
    }

    class Admin : User, IAdmin
    {
    }


    class Interfaces_Cast
    {
        public static void Entry()
        {
            User user = new User();
            Admin admin = new Admin();

            Console.WriteLine(user is IUser);
            Console.WriteLine(user is IAdmin);
            Console.WriteLine(admin is IUser);
            Console.WriteLine(admin is IAdmin);

            var correctCast1 = admin as IUser;
            var correctCast2 = (IUser)admin;
            var correctCast3 = admin as IUser;

            var incorrectCast1 = (IAdmin)user; // в отличие от ситуации с интерфейсами, это будет компилироваться

            user = admin;
            var incorrectCast2 = (IAdmin)user; // потому что после такого присвоения это было бы осмысленно
        }
    }
}
