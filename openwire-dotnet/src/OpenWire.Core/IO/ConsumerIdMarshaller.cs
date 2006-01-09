//
// Marshalling code for Open Wire Format for ConsumerId
//
//
// NOTE!: This file is autogenerated - do not modify!
//        if you need to make a change, please see the Groovy scripts in the
//        activemq-openwire module
//

using System;
using System.Collections;
using System.IO;

using OpenWire.Core;
using OpenWire.Core.Commands;
using OpenWire.Core.IO;

namespace OpenWire.Core.IO
{
    public class ConsumerIdMarshaller : AbstractCommandMarshaller
    {


        public override Command CreateCommand() {
            return new ConsumerId();
        }

        public override void BuildCommand(Command command, BinaryReader dataIn) {
            base.BuildCommand(command, dataIn);

            ConsumerId info = (ConsumerId) command;
            info.ConnectionId = dataIn.ReadString();
            info.SessionId = dataIn.ReadInt64();
            info.Value = dataIn.ReadInt64();

        }

        public override void WriteCommand(Command command, BinaryWriter dataOut) {
            base.WriteCommand(command, dataOut);

            ConsumerId info = (ConsumerId) command;
            dataOut.Write(info.ConnectionId);
            dataOut.Write(info.SessionId);
            dataOut.Write(info.Value);

        }
    }
}
