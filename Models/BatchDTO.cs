namespace FlowServer.Models
{
    public class BatchDTO
    {
        public int BatchId { get; set; }
        public DateTime SupplyDate { get; set; }
        public int Quantity { get; set; }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

        public List<ProductSettingsDTO> Settings { get; set; }
    }
}
