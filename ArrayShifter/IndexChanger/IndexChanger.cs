namespace ArrayShifter.IndexChanger
{
    /// <summary>
    /// Класс меняет местами элемент массива a[i] и его индекс i
    /// </summary>
    class IndexChanger
    {
        private int _arrayLength;
        private int _indexForChange;
        private string[] _arrayForChanges;
        
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="arrayLength"></param>
        /// <param name="arrayForChanges"></param>
        /// <param name="indexForChange"></param>
        public IndexChanger(int arrayLength, string[] arrayForChanges, int indexForChange)
        {
            this._arrayLength = arrayLength;
            this._arrayForChanges = arrayForChanges;
            this._indexForChange = indexForChange;
        }

        /// <summary>
        /// Метод меняет местами элемент массива и его индекс
        /// </summary>
        /// <returns></returns>
        private void ChangeData()
        {

        }
    }
}
