namespace Observer_Dp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Football football = new Football(new Location(1, 2, 3));
        
            Player P11 = new Player { Name = "Messi", Team="PSG" };
            Player P12 = new Player { Name = "Naymer", Team = "PSG" };


            Player P21 = new Player { Name = "Salah", Team = "Liverpool" };
            Player P22 = new Player { Name = "fermino", Team = "liverpool" };


            ReFree reFree = new ReFree() { Name = "Gresha" };

            football.Subscriber(P11);
            football.Subscriber(P12);
            football.Subscriber(P21);
            football.Subscriber(P22);
            football.Subscriber(reFree);


            Console.WriteLine("After Subscribe");

            football.Location = new Location(4, 5, 6);



        }
    }
}
