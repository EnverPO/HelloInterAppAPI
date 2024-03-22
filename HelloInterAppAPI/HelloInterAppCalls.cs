namespace Skyline.DataMiner.ConnectorAPI.SkylineCommunications.HelloInterAppCalls
{
    using System;
    using System.Linq;
    using Skyline.DataMiner.Core.DataMinerSystem.Common;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallBulk;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;
    using Skyline.DataMiner.Core.InterAppCalls.Common.Shared;
    using Skyline.DataMiner.Net;

    /// <summary>
    /// Class for inter app messaging
    /// </summary>
    public class HelloInterAppCalls : IInterAppElement
    {
        private TimeSpan defaultTimeout = TimeSpan.FromSeconds(60);

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="connection">Connection</param>
        /// <param name="element">Element</param>
        /// <exception cref="ArgumentNullException">Element cannot be null</exception>
        /// <exception cref="ArgumentException">Only use with the appropriate protocol</exception>
        public HelloInterAppCalls(IConnection connection, IDmsElement element)
        {
            if (element == null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            if (element.Protocol.Name != Constants.ProtocolName)
            {
                throw new ArgumentException($"The element is not running protocol '{Constants.ProtocolName}'", nameof(element));
            }

            Element = element;
            SLNetConnection = connection ?? throw new ArgumentNullException(nameof(connection));
        }

        /// <summary>
        /// DataMiner Element
        /// </summary>
        public IDmsElement Element { get; set; }

        /// <summary>
        /// Connection to SLNet
        /// </summary>
        public IConnection SLNetConnection { get; set; }

        /// <summary>
        /// Send message.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="timeout">Message timeout.</param>
        /// <returns>Message response.</returns>
        public Message SendMessage(Message message, TimeSpan timeout = default)
        {
            var interAppCallTimeout = timeout;
            if (timeout == default)
            {
                interAppCallTimeout = defaultTimeout;
            }

            IInterAppCall myCommand = InterAppCallFactory.CreateNew();
            myCommand.ReturnAddress = new ReturnAddress(Element.DmsElementId.AgentId, Element.DmsElementId.ElementId, Constants.InterAppResponsePID);
            myCommand.Messages.AddMessage(message);
            return myCommand.Send(SLNetConnection, Element.DmsElementId.AgentId, Element.DmsElementId.ElementId, Constants.InterAppReceiverPID, interAppCallTimeout, InterAppMessages.Types.KnownTypes).First();
        }
    }
}
