using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment9.Management_System
{
    public sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(
            string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress deliveryAddress)
            : base(trackingCode, description, weight, deliveryFee, deliveryAddress)
        {

        }
        public override decimal EstimatedCost
        {
            get { return deliveryfee + ((decimal)weight * 5); }
        }
        public override void PrintShipment()
        {
            Console.WriteLine($"Completed code : {trackingcode} Cost {EstimatedCost}");
        }


    }
}