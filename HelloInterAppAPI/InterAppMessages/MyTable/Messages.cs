namespace Skyline.DataMiner.ConnectorAPI.SkylineCommunications.HelloInterAppCalls.InterAppMessages.MyTable
{
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    /// <summary>
    /// Message for creating a new row.
    /// </summary>
    public class CreateRow : Message
    {
        /// <summary>
        /// Property holding the data for creating a new row.
        /// </summary>
        public MyTableData ExampleData { get; set; }
    }

    /// <summary>
    /// Response on the CreateRow message.
    /// </summary>
    public class CreateRowResponse : Message
    {
        /// <summary>
        /// Denotes if the message was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Response description
        /// </summary>
        public string Description { get; set; }
    }
}
