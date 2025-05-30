using System;

namespace Task5_Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var document = new TextDocument("Початковий текст.");
            var editor = new TextEditor(document);

            Console.WriteLine("Стан 1: " + editor.GetText());

            editor.Type("Додаємо першу зміну.");
            Console.WriteLine("Стан 2: " + editor.GetText());

            editor.Type("Додаємо другу зміну.");
            Console.WriteLine("Стан 3: " + editor.GetText());

            editor.Undo();
            Console.WriteLine("Відкат → Стан 2: " + editor.GetText());

            editor.Undo();
            Console.WriteLine("Відкат → Стан 1: " + editor.GetText());

            Console.ReadLine();
        }
    }
}
