namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double BaseSalary { get; set; }
        public DateTime BirthDate { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() { }

        public Seller(int id, string name, string email, double baseSalary, DateTime birthDate, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BaseSalary = baseSalary;
            BirthDate = birthDate;
            Department = department;
        }

        public void AddSales(SalesRecord Salesrecord)
        {
            Sales.Add(Salesrecord);
        }

        public void RemoveSales(SalesRecord Salesrecord)
        {
            Sales.Remove(Salesrecord);
        }

        public double TotalSales(DateTime initial, DateTime Final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= Final).Sum(sr => sr.Amount);
        }
    }
}
