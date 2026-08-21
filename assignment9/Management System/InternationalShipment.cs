using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment9.Management_System
{
    public class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        private string DestinationCountry;
        private decimal CustomsFee;

        public string destinoationCountry
        {
            get
            {
                return DestinationCountry;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Invalid destioationCountry ");
                    return;
                }
                DestinationCountry = value;
            }
        }
        public decimal customsFee
        {
            get { return CustomsFee; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid customsfee");
                    return;
                }
                CustomsFee = value;
            }
        }
        public override decimal EstimatedCost
        {
            get
            {
                return deliveryfee + ((decimal)weight * 5) + customsFee;
            }
        }
        public InternationalShipment(string TrackingCode, string Description, double Weight, decimal Delivryfee, DeliveryAddress Destination, decimal customsFee, string destinoationCountry) : base(TrackingCode, Description, Weight, Delivryfee, Destination)
        {
            DestinationCountry = destinoationCountry;
            CustomsFee = customsFee;
        }
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"Customs Report :{destinoationCountry} ");
        }
        public override string ToString()
        {
            return $"Tracking code: {trackingcode}, " +
                 $"Description : {description}, " +
                  $"Weight : {weight}" +
                  $"Delivryfee : {deliveryfee}" +
                  $"Destination : {destination}" +
                  $"customsFee: {customsFee}" +
                  $"destioationCountry : {destinoationCountry} " +
                  $"EstimatedCost : {EstimatedCost} ";

        }
        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking code: {trackingcode}");
            Console.WriteLine($"Description : {description} ");
            Console.WriteLine($"Weight : {weight}");
            Console.WriteLine($"Destination : {destination}");
            Console.WriteLine($"Delivryfee : {deliveryfee}");
            Console.WriteLine($"EstimatedCost :{EstimatedCost}");
            Console.WriteLine($"destinoationCountry : {destinoationCountry}");
            Console.WriteLine($"customsFee :{customsFee}");

        }

        public string GetTrackingStatus()
        {
            return $"Shipment {trackingcode} has been Delivered !";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }
    }
}