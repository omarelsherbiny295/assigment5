using System.Runtime.CompilerServices;

namespace assigment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1
            //Book book = new Book();

            //Console.WriteLine(book.password);

            ////compile time error because the private access modifier cannot accessed outside the class where it created 
            #endregion

            #region question2 
            //Book book = new Book();
            //Console.WriteLine(book.copiesinstockk);

            ////it complie because internal can accessed in any field  of the same project

            #endregion

            #region question3 
            Book book = new Book();
            book.title = "programming";
            Console.WriteLine(book.title);
            #endregion
        }
    }
}
