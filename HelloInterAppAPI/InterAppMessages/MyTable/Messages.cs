namespace Skyline.DataMiner.ConnectorAPI.SkylineCommunications.HelloInterAppCalls.InterAppMessages.MyTable
{
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    public class CreateRow : Message
    {
        public MyTableData ExampleData { get; set; }
    }

    public class CreateRowResponse : Message
    {
        public bool Success { get; set; }

        public string Description { get; set; }

        public CreateRow Request { get; set; }

        public string RowKey { get; set; }
    }
}
