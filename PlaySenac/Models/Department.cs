namespace PlaySenac.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Seller> Sellers { get; set; } 
            = new List<Seller>();

        public double TotalSales(DateTime initial, 
            DateTime final) {
            return Sellers.Sum( s => s.TotalSales(initial, final));
        }
    }
}
