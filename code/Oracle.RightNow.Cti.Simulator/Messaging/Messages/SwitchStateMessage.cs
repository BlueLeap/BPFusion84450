﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Oracle.RightNow.Cti.Providers.Simulator;

namespace Oracle.RightNow.Cti.Simulator.Messaging.Messages {
    [DataContract]
    public class SwitchStateMessage : Message {
        [DataMember]
        public IList<Device> Devices { get; set; }

        public override SwitchMessageType Type {
            get {
                return SwitchMessageType.SwitchState;
            }
            set {
                //
            }
        }
    }
}
