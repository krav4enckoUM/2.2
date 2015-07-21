using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Word
    {
        private string wordValue; //Значение слова
        private int numberOfDifferentLetters = 0; //Кол-во разных букв в слове

        public Word(string n) //Конструктор
        {
            if (n.Length > 0) //Определяем само слово
            {
                wordValue = n;
            }
            else wordValue = "DefaultWord";
            numberOfDifferentLetters = NumberOfDifferentLetters; //Определяем кол-во разных букв
        }

        public string WordValue
        {
            get { return wordValue; }
            set { wordValue = value; }
        } //Свойство доступа к переменной wordValue

        public int NumberOfDifferentLetters
        {
            get
            {
                var groups = WordValue.ToCharArray().GroupBy(c => c); //Лямбда-выражение для поиска разных букв
                foreach (var char_group in groups)
                    numberOfDifferentLetters++; //Подсчет кол-ва разных букв
                return numberOfDifferentLetters;
            }
        }//Свойство доступа к переменной numberOfDifferentLetters - Read Only

        public void OnScreen() //Метод вывода информации на экран
        {
            Console.Write("{0}: Длина слова: {1}, Кол-во разных букв: {2}.\n", wordValue, wordValue.Length, numberOfDifferentLetters);
        }
    }
}

