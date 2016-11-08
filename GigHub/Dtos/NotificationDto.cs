using System;
using GigHub.Models;

namespace GigHub.Dtos
{

    // Data transfer object
    public class NotificationDto
    {
    
        public DateTime DateTime { get; set; }
        public NotificationType Type { get; set; }
        public DateTime? OriginalDateTime { get; set; }
        public string OriginalVenue { get; set; }

       // Don't need it cause no validation
        public GigDto Gig { get; set; }
    }
}