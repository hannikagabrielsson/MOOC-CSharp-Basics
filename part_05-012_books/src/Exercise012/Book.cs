namespace Exercise012
{
    public class Book
    {

        private string name;
        private int publicationYear;

        public Book(string name, int publicationYear)
        {
            this.name = name;
            this.publicationYear = publicationYear;
        }

        public override bool Equals(object compared)
        {
            if (this == compared)
            {
                return true;
            }

            if ((compared == null) || !this.GetType().Equals(compared.GetType()))
            {
                return false;
            }

            Book comparedBook = (Book)compared;

            if (this.name == comparedBook.name &&
                this.publicationYear == comparedBook.publicationYear)
            {
                return true;
            }

            else
            {
                return false;
            }
        }




    }
}