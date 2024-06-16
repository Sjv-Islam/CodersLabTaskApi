namespace DotNetDeveloperRecruitmentTask.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public int? OrderId { get; set; }

        public int? VariantId { get; set; }

        public int Quantity { get; set; }

        public virtual Order? Order { get; set; }

        public virtual Variant? Variant { get; set; }
    }
}
