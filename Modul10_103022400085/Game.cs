namespace Modul10_103022400085
{
    public class Game
    {
        public int Id { get; set; }
        public String Nama { get; set; }
        public String Developer { get; set; }
        public int TahunRilis { get; set; }
        public String Genre { get; set; }
        public double Rating { get; set; }
        public String[] Platform { get; set; }
        public String[] Mode { get; set; }
        public bool IsOnline { get; set; }
        public int Harga { get; set; }

        public Game()
        {

        } 
    }
}
