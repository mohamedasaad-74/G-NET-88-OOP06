using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment9.Management_System
{
    public abstract partial class Shipment : ITrackable
    {
        
        public string trackingStatus = "In Transit";
        partial void OnTrackingStatusChanged(string newStatus);
        public string GetTrackingStatus()
        {
            return trackingStatus;
        }

        public void UpdateTrackingStatus(string newStatus)
        {
            trackingStatus = newStatus;
            OnTrackingStatusChanged(newStatus);
        }
    }
}