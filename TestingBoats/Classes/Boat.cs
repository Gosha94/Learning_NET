namespace TestingBoats.Classes
{
    class Boat
    {
        private int length;        
        
        public void setLength(int len)
        {
            length = len;
        }
        public int getLength()
        {
            return length;
        }
        public virtual string move()
        {
            return " drift ";
        }
    }
}