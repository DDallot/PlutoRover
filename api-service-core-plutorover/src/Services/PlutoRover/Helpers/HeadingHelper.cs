namespace Api.Services.Core.PlutoRover.Services.PlutoRover.Helpers
{
    public static class HeadingHelper
    {
        public static int FixedValue(int value)
        {
            if (value < 0)
            {
                return value + 360;
            }

            if (value >= 360)
            {
                return value % 360;
            }

            return value;
        }

        public static char ConvertToChar(int heading)
        {
            return heading switch
            {
                0 => Constants.North,
                90 => Constants.East,
                180 => Constants.South,
                270 => Constants.West,
                _ => ' ',
            };
        }
    }
}