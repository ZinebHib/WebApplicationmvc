namespace WebApplicationmvc.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public float Prix { get; set; }
        public string? Description { get; set; } //on ajoute ? pour dire que desc peut etre nulle ou vide 

      
    }
}
