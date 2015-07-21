using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void WriteList(List<Word> wordList) //Функция, выводящая весь список на экран
        {
            foreach (Word word in wordList)
            {
                word.OnScreen();
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random(); //Подключаем ГСЧ
            List<Word> WordList = new List<Word> //Создаем список
            {
                new Word("Hello") {},
                new Word("World") {},
                new Word("This") {},
                new Word("Is") {},
                new Word("Word") {}, //Заполняем экземплярами класса Word
            };

            Console.WriteLine("Список:\n");
            WriteList(WordList);

            Console.WriteLine("\nСортировка по длине слова:\n");
            WriteList(WordList.OrderBy(l => l.WordValue.Length).ToList());

            Console.WriteLine("\nДобавление элемента в конец:\n");
            WordList.Add(new Word("Qwerty") { });
            WriteList(WordList);

            Console.WriteLine("\nДобавление элемента после 3 позиции:\n");
            WordList.Insert(3, new Word("Test") { });
            WriteList(WordList);

            Console.WriteLine("\nУдаление обоих элементов:\n");
            WordList.RemoveAt(3);
            WordList.RemoveAt(5);
            WriteList(WordList);

            Console.WriteLine("\nПоиск по имени \"This\":\n");
            int i = WordList.FindIndex(k => k.WordValue == "This");
            Console.WriteLine("Результаты поиска:\n");
            WordList[i].OnScreen();

            Console.WriteLine("\nОчищенный список:\n");
            WordList.Clear();
            WriteList(WordList);

            Console.ReadKey();
        }
    }
}

