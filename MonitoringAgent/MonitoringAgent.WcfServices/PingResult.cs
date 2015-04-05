namespace MonitoringAgent.WcfServices
{
    /// <summary>
    /// Result of ping WCF service
    /// </summary>
    internal sealed class PingResult
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="result">Result</param>
        /// <param name="message">Message</param>
        public PingResult(bool result, string message = "")
        {
            Message = message;
            Result = result;
        }
        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; private set; }
        /// <summary>
        /// Result, true is ok, false is bad result
        /// </summary>
        public bool Result { get; private set; }
    }
}