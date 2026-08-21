using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment9.Management_System
{
    public abstract partial class Shipment
    {

        private string Trackingcode;
        private string Description;
        private double Weight;
        private decimal Deliveryfee;
        private DeliveryAddress Destination;
        private static int totalShipmentsCreated = 0;
        public string trackingcode
        {

            get
            {
                return Trackingcode;
            }
        }
        public string description
        {
            get { return Description; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    Description = value;
                    return;
                }
                Console.WriteLine("error");
            }
        }
        public double weight
        {
            get { return Weight; }

            set
            {
                if (value > 0)
                {
                    Weight = value;
                    return;
                }
                Console.WriteLine("error");
            }
        }

        public decimal deliveryfee
        {
            get { return Deliveryfee; }
            private set
            {
                if (value > 0)
                {
                    Deliveryfee = value;
                    return;
                }
                Console.WriteLine("error");
            }
        }
        public DeliveryAddress destination
        {
            get { return Destination; }
            set { Destination = value; }
        }
        public abstract decimal EstimatedCost
        {
            get;
        }
        public Shipment(string TrackingCode)

        {

            this.Trackingcode = TrackingCode;
            Description = "unknown";
            Weight = 1;
            Deliveryfee = 50;
            Destination = new DeliveryAddress();

        }
        public static int TotalShipmentsCreated
        {
            get { return totalShipmentsCreated; }
        }
        public Shipment(string TrackingCode, string Description, double Weight, decimal Delivryfee, DeliveryAddress Destination)
        {
            this.Trackingcode = TrackingCode;
            this.Description = string.IsNullOrWhiteSpace(Description) ? "Unknown" : Description;
            this.Weight = Weight > 0 ? Weight : 1.0;
            this.Deliveryfee = Delivryfee > 0 ? Delivryfee : 50;
            this.Destination = Destination;

        }
        public Shipment()
        {
            totalShipmentsCreated++;
        }
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                Deliveryfee = newFee;
                return;

            }
            Console.WriteLine("erorr");
        }
        public override string ToString()
        {
            return $"{Trackingcode} ,{Description}, {Weight} ,{Deliveryfee}. {Destination}.{EstimatedCost} ";


        }
        public abstract void PrintShipment();



        public void UpdateWeight(double newWeight)
        {
            this.weight = newWeight;
        }
        public void UpdateWeight(double newWeight, double ExtraPackingWieght)
        {
            this.weight = newWeight + ExtraPackingWieght;
        }
        public Shipment CopyShipment()
        {
            return (Shipment)this.MemberwiseClone();
        }
        public Shipment ShallowCopy()
        {
            return (Shipment)this.MemberwiseClone();
        }
        public Shipment DeepCopy()
        {
            Shipment copy = (Shipment)this.MemberwiseClone();


            {
                copy.destination = new DeliveryAddress(destination.city, destination.street, destination.buildingNumber);

            }

            return copy;
        }
        static Shipment()
        {
            totalShipmentsCreated = 0;
            Console.WriteLine("Shipment System Initialized");
        }
        public static int GetTotalShipmentsCreated()
        {
            return totalShipmentsCreated;
        } 
        partial void OnTrackingStatusChanged(string newStatus)
        {
            Console.WriteLine($"Tracking status changed to: {newStatus}");

        }

    }
}


