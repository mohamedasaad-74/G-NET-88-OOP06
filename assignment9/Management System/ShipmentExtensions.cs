using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment9.Management_System
{
    public static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            return $"{shipment.trackingcode} | {shipment.GetType().Name} | {shipment.weight} KG | {shipment.trackingStatus}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            return shipment.trackingStatus == "Delivered";
        }
    }
    }