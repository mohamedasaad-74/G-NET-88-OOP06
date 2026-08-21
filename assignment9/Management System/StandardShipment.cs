using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment9.Management_System
{
    public class StandardShipment : Shipment, ITrackable, IInsurable
    {



        public StandardShipment(string TrackingCode, string Description, double Weight, decimal Delivryfee, DeliveryAddress Destination) : base(TrackingCode, Description, Weight, Delivryfee, Destination)
        {

        }

        public override string ToString()
        {

            return $"TrackingCode   {trackingcode} , Description : {description}. Weight : {weight},Destination : {destination}";


        }
        public override decimal EstimatedCost
        {
            get { return deliveryfee + ((decimal)weight * 5); }

        }
        public override void PrintShipment()
        {

            Console.WriteLine($"Estimed cost {EstimatedCost} , TrackingCode   {trackingcode} , Description : {description}. Weight : {weight},Destination : {destination}");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {trackingcode} is Ready !";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }
    }
}