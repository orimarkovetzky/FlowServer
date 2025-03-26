namespace FlowServer.Models
{
    public class Machine
    {
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public int MachineType { get; set; }
        public float SetupTime { get; set; }
        public int Status { get; set; }


        public Machine(int machineId, string machineName, int machineType, float setupTime, int status)
        {
            MachineId = machineId;
            MachineName = machineName;
            MachineType = machineType;
            SetupTime = setupTime;
            Status = status;
        }
        public Machine()
        {

        }

        public int UpdateStatus(int status)
        {
            return 1;
        }

        public static List<Machine> ReadMachines()
        {
            MachineDBServices dbs = new MachineDBServices();
            return dbs.ReadMachines();
        }

    }
}
