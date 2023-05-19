namespace WebApplication12.Models
{
    public class Order
    {

        public int PetId { get; set; }
        public Service Service { get; set; }
        public Pet PetName { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public TypePayment Payment { get; set; }
        public OrderStatus Status { get; set; }
    }

    public enum TypePayment
    {
        Cash,
        Cashless,
        Half
    }

    public enum OrderStatus
    {
        Procesing,
        Complited
    }
}

