namespace Exercise011
{
    public class Song
    {
        private string artist;
        private string name;
        private int durationInSeconds;

        public Song(string artist, string name, int durationInSeconds)
        {
            this.artist = artist;
            this.name = name;
            this.durationInSeconds = durationInSeconds;
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

            Song comparedInput = (Song)compared;

            if (this.artist == comparedInput.artist &&
                this.name == comparedInput.name &&
                this.durationInSeconds == comparedInput.durationInSeconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return this.artist + ": " + this.name + " (" + this.durationInSeconds + " s)";
        }
    }
}