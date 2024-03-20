namespace Skyline.DataMiner.ConnectorAPI.SkylineCommunications.HelloInterAppCalls.InterAppMessages.MyTable
{
    using System;

    [Serializable]
    public class MyTableData
    {
        public string Instance { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CreditCardNumber { get; set; }

        public string ExpirationMonth { get; set; }

        public string ExpirationYear { get; set; }

        public string CVC { get; set; }

        public string MotherMaidenName { get; set; }

        public DateTime RequestSendTime { get; set; }

        public DateTime RequestReceiveTime { get; set; }
    }
}
