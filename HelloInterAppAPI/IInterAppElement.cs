﻿namespace Skyline.DataMiner.ConnectorAPI.SkylineCommunications.HelloInterAppCalls
{
    using System;
    using Skyline.DataMiner.Core.DataMinerSystem.Common;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;
    using Skyline.DataMiner.Net;

    /// <summary>
    /// Defines an Example Connector InterApp Calls element.
    /// </summary>
    public interface IInterAppElement
    {
        /// <summary>
        /// DataMiner Element Interface.
        /// </summary>
        IDmsElement Element { get; }

        /// <summary>
        /// The SLNet Connection to use.
        /// </summary>
        IConnection SLNetConnection { get; set; }

        /// <summary>
        /// Sends the specified message to the element using InterApp and wait for the responses.
        /// </summary>
        /// <param name="message">The message that needs to be send.</param>
        /// <param name="timeout">The time the method needs to wait for a response.</param>
        /// <returns>The response coming from the device</returns>
        Message SendMessage(Message message, TimeSpan timeout = default);
    }
}
