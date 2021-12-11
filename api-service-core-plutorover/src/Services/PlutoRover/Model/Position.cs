namespace Api.Services.Core.PlutoRover.Services.PlutoRover.Model
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Heading { get; set; }

        public Position() { }
        public Position(int x, int y, int heading)
        {
            X = x;
            Y = y;
            Heading = heading;
        }

        public Position Clone()
        {
            return new Position(X, Y, Heading);
        }
    }
}