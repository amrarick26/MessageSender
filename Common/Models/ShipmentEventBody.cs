﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderCloudMessageSender.Common
{
	public class ShipmentEventBody : OrderEventBody
	{
		public Shipment Shipment { get; set; }
		public List<ShipmentItem> ShipmentItems { get; set; }
	}
}
