using Stepik.OOP.LessonInfrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stepik.OOP
{

    public interface IFigure
    {
        Point Location { get; set; }
        bool Contains(Point p);
        double Area { get; }
    }

    public static class IFigureExtensions
    {
        public static bool Contains(this IFigure obj, Point[] points)
        {
            foreach (var p in points)
                if (obj.Contains(p)) return true;
            return false;
        }
    }

    /// <summary>
    /// Пример Полиморфизма на интерфейсах
    /// </summary>
    class Intrface_Polymorphism
    {
    }
}
