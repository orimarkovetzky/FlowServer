namespace FlowServer.Models
{
    public class ProductSettingsDTO
    {
            public int MachineType { get; set; }
            public string MachineTypeName { get; set; }
            public float ProcessTime { get; set; }
            public float? Flow { get; set; }
            public float? Grit { get; set; }
            public int? Temperature { get; set; }

        public ProductSettingsDTO() { }
    }
}
