using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Work_19
{
    class  AllLibrary : Library
    {
        
        public override void Write(string text, string way, bool add)
        {
            base.Write(text, way, add);
          
        }

        public override void Search(string way, string search)
        {
            base.Search(way, search);
        }
        public override void Delete(string way, string search)
        {
            base.Delete(way, search);
            
        }
        public override void Sortirovka(string way)
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
        public override void Text_OutPut(string way)
        {
            Console.WriteLine("_________________________________________________________________________________________________________________________________________________");
            Console.WriteLine("{0,0}{1,10}{2,1}{3,40}{4,30}{5,18}{6,2}{7,25}{8,15}", "|", " Номер книги ", "|", "Название книги", "|", "Год издания книги", "|", "Автор книги", "|");
            Console.WriteLine("_________________________________________________________________________________________________________________________________________________");
            List<string> text_split;
            StreamReader info = new StreamReader(way, System.Text.Encoding.Default);
            string line;

            while ((line = info.ReadLine()) != null)
            {
                text_split = line.Split(';').ToList<string>();
                Console.WriteLine("{0,0}{1,10}{2,4}{3,40}{4,30}{5,18}{6,2}{7,25}{8,15}", "|",text_split[0], "|", text_split[1], "|",text_split[2], "|", text_split[3], "|");
                Console.WriteLine("_________________________________________________________________________________________________________________________________________________");



            }
            info.Close();
        }

    }
}
