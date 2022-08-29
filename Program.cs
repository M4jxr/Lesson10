using OOPproject;
using System;

//Console.OutputEncoding = System.Text.Encoding.UTF8;

namespace OOPproject
{

    class Program
    {

        static void Main()
        {
            List<string> names = new List<string>{ "1984 , Над пропастью во ржи , Великий Гэтсби , .... " };
         
            Library a = new Library(names , "Мастер и Маргарита" , 1000);
            Library b = new Library();
            Library c = new Library(1000);


            a.ShowInfo();
            

            

        }


    }



}
    






