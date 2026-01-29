namespace TP1_Resto.Models
{
    public class Plat
    {
        public int Id { get; set; }
        public string Nom {  get; set; }
        public double Prix { get; set; }
        
        //Doit avoir au moins 4 catégories
        public string Catégorie { get; set; }
        public string CheminImage { get; set; }
        public int RestaurantId { get; set; }
    }
}
