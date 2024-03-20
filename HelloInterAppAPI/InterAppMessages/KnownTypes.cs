using System;
using System.Collections.Generic;
using Skyline.DataMiner.ConnectorAPI.SkylineCommunications.HelloInterAppCalls.InterAppMessages.MyTable;

namespace Skyline.DataMiner.ConnectorAPI.SkylineCommunications.HelloInterAppCalls.InterAppMessages
{
    /// <summary>
    /// Static class holding the types of the InterApp Messages
    /// </summary>
    public static class Types
    {
        /// <summary>
        /// Gets a list of all the supported InterApp Message Types.
        /// </summary>
        public static List<Type> KnownTypes { get; } = new List<Type>
        {
            typeof(CreateRow),
            typeof(CreateRowResponse),
        };
    }
}
