using System;
using System.Globalization;


namespace Work_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\t\tПрограмма для добавление книг в текстовый файл ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n С какой библиотекой вы хотите работать? 1 - С домашней библиотекой; 2 - C общей библиотекой");
            Console.Write("\n Ваш ответ: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("\n\t\t\tДобавить информацию - 1; Перезаписать информацию - 2; 3 - Посмотреть результаты ");
            Console.Write("\nВаш ответ: ");
            int c = int.Parse(Console.ReadLine());
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            Library library = new Library();
            AllLibrary alllibrary = new AllLibrary();

            switch (y) {
            case 1:

            switch (c)
            {
                case 1:
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    bool add = true;
                    if (c == 1)
                    {
                        add = true;
                    }

                    if (c == 2)
                    {
                        add = false;
                    }

                    bool b = true;
                    string text = null;
                    while (b == true)
                    {
                        Console.Write("\nВведите название книги: ");
                        string Name = ti.ToTitleCase(Console.ReadLine());
                        Console.Write("\nВведите год издания книги:  ");
                        int Year = int.Parse(Console.ReadLine());
                        Console.Write("\nВведите автора книги: ");
                        string Author = Console.ReadLine();
                        Console.WriteLine("\n Хотите еще ввести данные? 1 -Да; 2 - Нет");
                        Console.Write("\n Ваш ответ: ");
                        int n = int.Parse(Console.ReadLine());
                        if (n == 2)
                        {
                            b = false;
                            text += $";{Name};{Year};{Author};";
                        }
                        else
                        {
                            text += $";{Name};{Year};{Author};" + "\n";
                        }


                    }
                    string way = @"d://Home_Library.txt";

                    library.Write(text, way, add);
                    Console.WriteLine("\n Книга добавлена!");



                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    way = @"d://Home_Library.txt";
                    Console.WriteLine("\n Хотите просмотреть список книг? 1 - да; 2 - нет");
                    Console.Write("\n Ваш ответ: ");
                    if (int.Parse(Console.ReadLine()) == 1)
                    {
                        Console.WriteLine("\n\t\t\tСписок книг в домашней  библиотеке:");
                        library.Sortirovka(way);
                        library.Text_OutPut(way);
                    }

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\n Хотите найти нужную книгу? 1 - да; 2 - нет");
                    Console.Write("\n Ваш ответ: ");
                    if (int.Parse(Console.ReadLine()) == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("\n Введите название книги для поиска: ");
                        string search = ti.ToTitleCase(Console.ReadLine());
                        library.Search(way, search);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n Хотите удалить ненужную книгу? 1 - да; 2 - нет");
                    Console.Write("\n Ваш ответ: ");
                    if (int.Parse(Console.ReadLine()) == 1)
                    {
                        Console.Write("\n Введите название книги для удаления : ");
                        string search = ti.ToTitleCase(Console.ReadLine());
                        library.Delete(way, search);
                    }


                    break;


            }
                break;


                case 2:

                    switch (c)
                    {
                        case 1:
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            bool add = true;
                            if (c == 1)
                            {
                                add = true;
                            }

                            if (c == 2)
                            {
                                add = false;
                            }

                            bool b = true;
                            string text = null;
                            while (b == true)
                            {
                                Console.Write("\nВведите id книги:  ");
                                int Number = int.Parse(Console.ReadLine());
                                Console.Write("\nВведите название книги: ");
                                string Name = ti.ToTitleCase(Console.ReadLine());
                                Console.Write("\nВведите год издания книги:  ");
                                int Year = int.Parse(Console.ReadLine());
                                Console.Write("\nВведите автора книги: ");
                                string Author = Console.ReadLine();
                                Console.WriteLine("\n Хотите еще ввести данные? 1 -Да; 2 - Нет");
                                Console.Write("\n Ваш ответ: ");
                                int n = int.Parse(Console.ReadLine());
                                if (n == 2)
                                {
                                    b = false;
                                    text += $"{Number};{Name};{Year};{Author};";
                                }
                                else
                                {
                                    text += $"{Number};{Name};{Year};{Author};" + "\n";
                                }


                            }
                            string way = @"d://All_Library.txt";

                            library.Write(text, way, add);
                            Console.WriteLine("\n Книга добавлена!");



                            break;

                        case 3:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            way = @"d://All_Library.txt";
                            Console.WriteLine("\n Хотите просмотреть список книг? 1 - да; 2 - нет");
                            Console.Write("\n Ваш ответ: ");
                            if (int.Parse(Console.ReadLine()) == 1)
                            {
                                Console.WriteLine("\n\t\t\tСписок книг в общей  библиотеке:");
                                alllibrary.Sortirovka(way);
                                alllibrary.Text_OutPut(way);
                            }

                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("\n Хотите найти нужную книгу? 1 - да; 2 - нет");
                            Console.Write("\n Ваш ответ: ");
                            if (int.Parse(Console.ReadLine()) == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.Write("\n Введите название книги для поиска: ");
                                string search = ti.ToTitleCase(Console.ReadLine());
                                alllibrary.Search(way, search);
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n Хотите удалить ненужную книгу? 1 - да; 2 - нет");
                            Console.Write("\n Ваш ответ: ");
                            if (int.Parse(Console.ReadLine()) == 1)
                            {
                                Console.Write("\n Введите название книги для удаления : ");
                                string search = ti.ToTitleCase(Console.ReadLine());
                                alllibrary.Delete(way, search);
                            }


                            break;


                    }

                    break;
        }

            Console.ReadLine();
        }
    }
}
