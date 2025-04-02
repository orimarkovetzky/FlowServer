namespace FlowServer.Models
{
    public class Batch
    {
        public int BatchId { get; set; }
        public int ProductId { get; set; }
        public DateTime SupplyDate { get; set; }
        public int Quantity { get; set; }

        public Batch(int batchId, int productId, DateTime supplyDate, int quantity)
        {
            BatchId = batchId;
            ProductId = productId;
            SupplyDate = supplyDate;
            Quantity = quantity;
        }
    }
}
