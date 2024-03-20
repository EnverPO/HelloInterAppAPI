namespace Skyline.DataMiner.ConnectorAPI.SkylineCommunications.HelloInterAppCalls
{
    /// <summary>
    /// Constant values for this API.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// The protocol name of the Skyline Communications Example Connector InterApp Calls.
        /// </summary>
        public const string ProtocolName = "Hello InterApp Communications";

        /// <summary>
        /// The ID of the parameter that will receive the InterApp Messages
        /// </summary>
        public const int InterAppReceiverPID = 9000000;

        /// <summary>
        /// The ID of the parameter that will hold the responses for the InterApp Messages
        /// </summary>
        public const int InterAppResponsePID = 9000001;
    }
}
