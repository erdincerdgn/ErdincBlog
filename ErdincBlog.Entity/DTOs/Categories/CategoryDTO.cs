namespace ErdincBlog.Entity.DTOs.Categories
{
    public class CategoryDTO
    {

        public Guid Id { get; set; }
        // prop'un ismi Category Entitysindeki Name fieldiyle aynı olması gerekiyor. (MSSQL)
        public string Name  { get; set; }
    }
}
