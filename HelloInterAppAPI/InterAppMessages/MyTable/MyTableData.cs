namespace Skyline.DataMiner.ConnectorAPI.SkylineCommunications.HelloInterAppCalls.InterAppMessages.MyTable
{
    using System;

    /// <summary>
    /// Credit card data displayed in the table
    /// </summary>
    [Serializable]
    public class MyTableData
    {
        /// <summary>
        /// Instance property
        /// </summary>
        public string Instance { get; set; }

        /// <summary>
        /// First name property
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name property
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Credit card number property
        /// </summary>
        public string CreditCardNumber { get; set; }

        /// <summary>
        /// Credit card expirtion month property
        /// </summary>
        public string ExpirationMonth { get; set; }

        /// <summary>
        /// Credit card expirtion year property
        /// </summary>
        public string ExpirationYear { get; set; }

        /// <summary>
        /// Credit card CVC number
        /// </summary>
        public string CVC { get; set; }

        /// <summary>
        /// Credit card holder's mother's maiden name
        /// </summary>
        public string MotherMaidenName { get; set; }
        /// <summary>
        /// Time at which the request was sent
        /// </summary>
        public DateTime RequestSendTime { get; set; }
    }
}
