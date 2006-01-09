//
// Marshalling code for Open Wire Format for LocalTransactionId
//
//
// NOTE!: This file is autogenerated - do not modify!
//        if you need to make a change, please see the Groovy scripts in the
//        activemq-openwire module
//

using System;
using System.Collections;

using OpenWire.Core;

namespace OpenWire.Core.Commands
{
    public class LocalTransactionId : TransactionId
    {
    			public const byte ID_LocalTransactionId = 111;
    			
        long value;
        ConnectionId connectionId;



        // TODO generate Equals method
        // TODO generate GetHashCode method
        // TODO generate ToString method


        public override byte GetCommandType() {
            return ID_LocalTransactionId;
        }


        // Properties

        public long Value
        {
            get
            {
                return value;
            }
            set
            {
                value = value;
            }            
        }

        public ConnectionId ConnectionId
        {
            get
            {
                return connectionId;
            }
            set
            {
                connectionId = value;
            }            
        }

    }
}
