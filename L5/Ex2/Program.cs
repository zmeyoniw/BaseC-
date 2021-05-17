using System;
using System.Text;
using System.Collections.Generic;


namespace Ex2
{
    class Message
    {
        /// <summary>
        /// выводит слова определенной длины
        /// </summary>
        public static string WordLength(string a,int b)
        {
            string[] words = a.Split(' ','.',',','-','!','?',':',';',')','(');
            string result = String.Empty;
            for (int i = 0; i < words.Length; i++) if (words[i].Length == b) result += " " + words[i];
            return result;
        }
        /// <summary>
        /// Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        /// </summary>
        public static string DeleteWord(string a,char b)
        {
            string sr = String.Empty;
            string[] words = a.Split(' ', '.', ',', '-', '!', '?', ':', ';', ')', '(');
            for (int i = 0; i < words.Length; i++) if (words[i].EndsWith(b)) Array.Clear(words, i, 1); else sr = sr + " " + words[i];
            return sr;
        }
        /// <summary>
        /// Найти самое длинное слово сообщения.
        /// </summary>
        public static string BiggestWord(string a)
        {
            string[] words = a.Split(' ', '.', ',', '-', '!', '?', ':', ';', ')', '(');
            string bw = words[0];
            for (int i = 0; i < words.Length; i++) if (words[i].Length > bw.Length) bw = words[i]; return bw;
        }
        /// <summary>
        /// Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        /// </summary>
        public static string MakeStr(string a)
        {
            string[] words = a.Split(' ', '.', ',', '-', '!', '?', ':', ';', ')', '(');
            string bw = words[0];
            for (int i = 0; i < words.Length; i++) if (words[i].Length > bw.Length) bw = words[i];
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < words.Length; i++) if (words[i].Length == bw.Length) sb.Append(words[i]); return sb.ToString();
        }
        /// <summary>
        ///  ***Создать метод, который производит частотный анализ текста. 
        ///  В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. 
        ///  Здесь требуется использовать класс Dictionary.
        /// </summary>
        public static Dictionary<string,int> WordNumber(string a, string b)
        {
            string[] words = a.Split(' ', '.', ',', '-', '!', '?', ':', ';', ')', '(');
            string[] searchWord = b.Split(' ', '.', ',', '-', '!', '?', ':', ';', ')', '(');
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach(var c in searchWord)
            {
                result.Add(c, 0);
            }
            foreach(var word in words)
            {
                if (result.ContainsKey(word)) 
                result[word]++;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string letter = "«Чёрная лагуна» — маленькая компания, которая доставляет грузы, зачастую нелегальные, по всему Южно-Китайскому морю. " +
                "Тёмная сторона жизни Таиланда, Филиппин, Малайзии, Индонезии и даже Японии. " +
                "Мафии разных стран — от Китая и Италии до Колумбии и России — бьются за власть в главном пиратском городе восточных морей, мифическом Роанапуре.";
            char x = Convert.ToChar(Console.ReadLine());
            string word = "сторона и за";
            Console.WriteLine(Message.DeleteWord(letter, x));
            Console.WriteLine(Message.WordLength(letter, 4));
            Console.WriteLine(Message.BiggestWord(letter));
            Console.WriteLine(Message.MakeStr(letter));
            foreach (var item in Message.WordNumber(letter,word)) Console.WriteLine(item);
        }
    }
}
