namespace ToDoApi.Models
{
    public class ToDoItem
    {
        public LinkGenerator Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
