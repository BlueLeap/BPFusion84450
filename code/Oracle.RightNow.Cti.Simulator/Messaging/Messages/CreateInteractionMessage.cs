﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Oracle.RightNow.Cti.Providers.Simulator;

namespace Oracle.RightNow.Cti.Simulator.Messaging.Messages {
    [DataContract]
    public class CreateInteractionMessage : Message {
        [DataMember]
        public SwitchInteraction Interaction { get; set; }

        [DataMember]
        public override SwitchMessageType Type {
            get {
                return SwitchMessageType.CreateInteraction;
            }
            set {
                //
            }
        }
    }
}
