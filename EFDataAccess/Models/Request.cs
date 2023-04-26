namespace EFDataAccess.Models;

public class Request
{
    public enum RequestStatus
    {
        New = 1,
        Quoting = 2,
        Waiting = 3,
        Approved = 4,
        Posted = 5,
        Closed = 6,
        Cancelled = 7
    }

    public int RequestId { get; set; } 
    public User RequestOwner { get; set; } 

    public RequestStatus Status { get; set; } 
    public string Title { get; set; } 

    public List<RequestLine> RequestLines { get; set; }
}