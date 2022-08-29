using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject
{
    public class Library
    {
        private List<string>  ListofBooks;

        private string nameofBooks;

        private int amountofBooks;




        public Library(List<string>  ListofBooks , string nameofBooks , int amountofBooks)
        {

            this.ListofBooks = ListofBooks;
            this.nameofBooks = nameofBooks;
            this.amountofBooks = amountofBooks;
        }

        public Library()
        {


        }

        public Library(int amountofBooks)
        {


        }

        public void ShowInfo()
        {

            Console.WriteLine(($"Number of books: {amountofBooks}"));
            foreach (var el in ListofBooks)
            {
                Console.WriteLine(el);

            }
            Console.WriteLine("choose" );
        }

    }   
    

    

    


}
