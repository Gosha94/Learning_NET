using Stepik.OOP.LessonInfrastructure;

namespace Stepik.OOP
{

    abstract class Figure1
    {
        public Point Location { get; set; }

        //Метод Contains также стал абстрактным
        public abstract bool Contains(Point p);

        public bool Contains(Point[] points)
        {
            foreach (var p in points)
                if (Contains(p)) return true;
            return false;
        }

        // Метод GetArea заменен на абстрактное свойство
        public abstract double Area { get; }

        //Добавили перегрузку метода ToString
        public override string ToString()
        {
            return GetType().Name + " at " + Location.ToString();
        }

    }

    /// <summary>
    /// Пример Полиморфизма на абстрактных базовых классах
    /// </summary>
    class AbstractBase_Polymorphism
    {
    }
}
