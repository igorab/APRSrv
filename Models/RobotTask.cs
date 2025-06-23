namespace APRSrv.Models
{
    public class RobotTask
    {
        public DateTime Date { get; set; }

        public int TaskId { get; set; }

        public int TaskValue { get; set; }

        public string? TaskName { get; set; }
    }
}
