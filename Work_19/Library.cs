using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Work_19
{
    class Library
    {
        public Library()
        {

        }
        
        public virtual void Write(string text, string way, bool add)
        {

            StreamWriter info = new StreamWriter(way, add, System.Text.Encoding.Default);
            info.WriteLine(text);
            info.Close();
            
        }
        

        public virtual  void Search (string way, string search)
        {
            StreamReader info = new StreamReader(way, System.Text.Encoding.Default);

            string line;
            bool b = false;
            while ((line = info.ReadLine()) != null)
            {
                if (line.Contains(search))
                {
                    b = true;
                    List<string> text_split = new List<string>();
                    text_split = line.Split(';').ToList<string>();
                    if (text_split[0]!="")
                    {
                        Console.WriteLine($"\n Номер книги:{text_split[0]} \n Название книги: {text_split[1]} \n Год: {text_split[2]}  \n Автор: {text_split[3]}");
                    }
                    else
                    {
                        Console.WriteLine($"\n Название книги: {text_split[1]} \n Год: {text_split[2]}  \n Автор: {text_split[3]}");
                    }
                }
                    

            }
            if (b == false)
            {
                Console.WriteLine("\n Книга не существует, проверьте правильность введенных данных!");
            }
            info.Close();

        }
        public virtual void Sortirovka(string way)
        {
            StreamReader info = new StreamReader(way, System.Text.Encoding.Default);
            
                string line;
                List<string> text = new List<string>();
                while ((line = info.ReadLine()) != null)
                {

                    text.Add(line);

                }
                text.Sort();
                info.Close();

                StreamWriter info1 = new StreamWriter(way, false, System.Text.Encoding.Default);
                for (int i = 0; i < text.Count; i++)
                {
                    info1.WriteLine(text[i]);
                }
                info1.Close();
            
        }   
        public virtual void Text_OutPut(string way) 
        {
            Console.WriteLine("_______________________________________________________________________________________________________________________________________________");
            Console.WriteLine("{0,0}{1,40}{2,30}{3,5}{4,5}{5,30}{6,20}", "|", "Название книги", "|", "Год издания книги", "|", "Автор книги", "|");
            Console.WriteLine("_______________________________________________________________________________________________________________________________________________");
            List<string> text_split;
            StreamReader info = new StreamReader(way, System.Text.Encoding.Default);
            string line;

            while ((line = info.ReadLine()) != null)
            {
                text_split = line.Split(';').ToList<string>();
                Console.WriteLine("{0,0}{1,40}{2,30}{3,5}{4,17}{5,30}{6,20}", "|", text_split[1], "|", text_split[2], "|", text_split[3], "|", text_split[4], "|");
                Console.WriteLine("_______________________________________________________________________________________________________________________________________________");



            }
            info.Close();

        }
       

        public virtual void  Delete (string way, string search)
        {
            StreamReader info = new StreamReader(way, System.Text.Encoding.Default);
            List<string> text = new List<string>();
            string line;
            bool b = false;

            while ((line = info.ReadLine()) != null)
            {
                if (line.Contains(search))
                {
                    b = true;

                }
                else
                {

                    text.Add(line);
                }
            }
            if (b == false)
            {
                Console.WriteLine("\n Книга не существует, проверьте правильность введенных данных!");
            }
            else
            {
                Console.WriteLine("\n Книга удалена!");
            }
            info.Close();
            StreamWriter info1 = new StreamWriter(way, false, System.Text.Encoding.Default);

            for (int i = 0; i < text.Count; i++)
            {
                info1.WriteLine(text[i]);
            }
            info1.Close();

        }

     
    }
}
