using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayShifter.IndexChanger
{
    /// <summary>
    /// Класс меняет местами элемент массива a[i] и его индекс i
    /// </summary>
    public class ArrayIndexChanger
    {
        private int _arrayLength;
        private int _elemNumberForChange;
        private string _inputData;

        private string[] _strArrayForChanges;
        private List<int> _convertedIntList;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="arrayLength">Длина строкового массива, целое число > 0</param>
        /// <param name="arrayForChanges"></param>
        /// <param name="elemNumberForChange">Номер элемента массива, у которого значени будет заменено на его индекс</param>
        public ArrayIndexChanger(int arrayLength, string inputData, int elemNumberForChange)
        {
            this._arrayLength = arrayLength;
            this._inputData = inputData;
            this._elemNumberForChange = elemNumberForChange;            
            this._convertedIntList = new List<int>();
            
            PrepareInputDataForWork();

            ValidateStringArrayLength();

            ConvertStrArrayToIntArray();

            ReplaceIndexWithValue();

            BackConvertToStrArray();
        }

        /// <summary>
        /// Метод возвращает массив string[] с замененным элементом
        /// </summary>
        /// <returns></returns>
        public string[] GetChangedArray() => this._strArrayForChanges;

        /// <summary>
        /// Метод подготавливает массив из входной строки
        /// </summary>
        private void PrepareInputDataForWork()
        {
            this._strArrayForChanges = this._inputData.Trim().Split(' ').ToArray();
        }

        /// <summary>
        /// Метод заменяет значение элемента массива на его индекс
        /// </summary>
        /// <returns></returns>
        private void ReplaceIndexWithValue()
        {
            var indexForChange = this._elemNumberForChange - 1;
            this._convertedIntList[indexForChange] = indexForChange;
        }

        /// <summary>
        /// Метод проверяет соответствие вводимой длины массива и длиной получившегося массива
        /// </summary>
        private void ValidateStringArrayLength()
        {
            if (this._arrayLength != this._strArrayForChanges.Length)
            {
                throw new Exception("Input Array Length is incorrect!");
            }
            if (this._strArrayForChanges.Length < this._elemNumberForChange)
            {
                throw new Exception("Input Value For Change is incorrect!");
            }
        }

        /// <summary>
        /// Преобразование массива строк в массив целых чисел
        /// </summary>
        private void ConvertStrArrayToIntArray()
        {
            foreach  (var elem in this._strArrayForChanges)
            {
                var checkedElement = elem.Trim();
                int insertedData;
                
                bool isSuccessConvert = Int32.TryParse(checkedElement, out insertedData);

                if (!isSuccessConvert)
                {
                    throw new Exception(@"Value for convert is incorrect! Please correcting input data");
                }
                else
                {
                    this._convertedIntList.Add(insertedData);
                }
            }
        }
        

        /// <summary>
        /// Преобразование массива целых чисел в массив строк
        /// </summary>
        private void BackConvertToStrArray()
        {
            this._strArrayForChanges = this._convertedIntList.Select(x => x.ToString()).ToArray();
        }
    }
}
