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
            //Book book = new Book();
            //book.title = "programming";
            //Console.WriteLine(book.title);
            #endregion

            #region question4
            //Book book = new Book();
            //book.Genre = genre.science;
            //Console.WriteLine(book.Genre);
            #endregion

            #region question5 
            //Console.WriteLine((int)genre.fiction);
            //Console.WriteLine((int)genre.nonfiction);
            //Console.WriteLine((int)genre.science);

            #endregion
            #region question6
            //cant answer
            #endregion

            #region question7
            genre Genre = genre.fiction;
            string text=Genre.ToString();
            Console.WriteLine(text);
            Console.WriteLine(text.GetType());
            #endregion
        }
    }
}
