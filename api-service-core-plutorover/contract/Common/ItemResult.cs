namespace Api.Contracts.Core.PlutoRover.Common
{
    public class ItemResult <T> : NoResult
    {
        public T Item { get; set; }
    }
}
