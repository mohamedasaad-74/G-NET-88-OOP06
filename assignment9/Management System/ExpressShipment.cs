using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment9.Management_System
{
    public class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        public decimal ExtraFee;
        public decimal extraFee
        {
            get { return ExtraFee; }
            set
            {
                if (value >= 0)
                {
                    ExtraFee = value;
                    return;
                }
                Console.WriteLine("Enter a value");
            }
        }
        public ExpressShipment(string TrackingCode, string Description, double Weight, decimal Delivryfee, DeliveryAddress Destination, decimal extraFee) : base(TrackingCode, Description, Weight, Delivryfee, Destination)
        {
            ExtraFee = extraFee;
        }
        public override decimal EstimatedCost
        {
            get { return deliveryfee + ((decimal)weight * 5) + extraFee; }
        }
        public override string ToString()
        {
            return $"Tracking code: {trackingcode}, " +
               $"Description : {description}, " +
                $"Weight : {weight}" +
                $"Delivryfee : {deliveryfee}" +
                $"Destination : {destination}" +
                $"Extrafee : {extraFee}" +
                $"EstimatedCost : {EstimatedCost} ";


        }
        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking code: {trackingcode}");
            Console.WriteLine($"Description : {description} ");
            Console.WriteLine($"Weight : {weight}");
            Console.WriteLine($"Destination : {destination}");
            Console.WriteLine($"Delivryfee : {deliveryfee}");
            Console.WriteLine($"EstimatedCost : {EstimatedCost} ");
            Console.WriteLine($"Extrafee : {extraFee}");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {trackingcode}  is Out for Delivery !";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }
    }
}