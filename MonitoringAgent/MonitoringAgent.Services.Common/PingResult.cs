namespace MonitoringAgent.Services.Common
{
    public class PingResult
    {
        public PingResult(bool result, string message = "")
        {
            Message = message;
            Result = result;
        }
        public string Message { get; set; }
        public bool Result { get; set; }
    }
}