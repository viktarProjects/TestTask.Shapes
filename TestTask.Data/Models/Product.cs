namespace TestTask.Data.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<Category> Categories { get; set; } = new List<Category>();
    }
}
