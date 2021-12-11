﻿namespace Supercell.Laser.Server.Protocol.Messages.Server.Security
{
    using Supercell.Laser.Server.Network;
    using Supercell.Laser.Server.Protocol.Enums;
    using Supercell.Laser.Titan.Logic.Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class ServerHelloMessage : PiranhaMessage
    {
        /// <summary>
        /// The service node for this message.
        /// </summary>
        internal override ServiceNode Node
        {
            get
            {
                return ServiceNode.Account;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerHelloMessage"/> class.
        /// </summary>
        public ServerHelloMessage(Connection connection) : base(connection)
        {
            this.Type = Message.ServerHello;
            this.Connection.State = State.HandshakeSuccess;
        }

        internal override void Encrypt()
        {
            this.Length = this.Stream.Length;
        }

        internal override void Encode()
        {
            Stream.Write(Encoding.UTF8.GetBytes(Connection.Nonce));

            /*Stream.WriteInt(24);

            for (int i = 0; i < 24; i++)
            {
                Stream.WriteByte(0xFF);
            }*/
        }
    }
}
