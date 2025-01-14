namespace EventSLn
{
	internal class Program
	{
		static void Main(string[] args)
		{
		Ball ball = new Ball() { Id=1234};
			Console.WriteLine(ball.BallLocation);
			//ball.BallLocation = new Location(50, 60, 70); // no one intersedt we needd to create player

			Player P11 = new Player() { Name="Messi" ,Team= "PSG"};
			Player P12 = new Player() { Name = "Naymer", Team = "PSG" };
			Player P21 = new Player() { Name = "Saleh", Team = "LiverPool" };
			Player P22 = new Player() { Name = "Mane", Team = "LiverPool" };
			//
			//
			//ball.BallLocation = new Location(5, 6, 7);
            // we need to make player interset with theb ball 
            Console.WriteLine("After Match Starting intersed");
            ball.BallLocationChanged += P11.Run;
			ball.BallLocationChanged += P21.Run;
			ball.BallLocationChanged += P21.Run;
			ball.BallLocationChanged += P22.Run;

			ball.BallLocation = new Location(50, 60, 70);
		}
	}
}