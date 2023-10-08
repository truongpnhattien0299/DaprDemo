namespace DaprDemo.Ordering.Domain
{
    public record Order(int Id, string UserId, DateTime CreatedAt);
}