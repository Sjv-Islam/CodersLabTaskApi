namespace DotNetDeveloperRecruitmentTask.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string CustomerName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Address { get; set; } = null!;

        public int TotalQuantity { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
