namespace PiggyBank.Models
{
    public class RequestModel
    {
        public RequestModel()
        {
            RequestId = 1;
            RequestOwner = null;
            Status = RequestStatus.New;
            Title = "";
        }

        public RequestModel(int reqId, UserModel requestOwner, RequestStatus reqStatus, string title)
        {
            RequestId = reqId;
            RequestOwner = requestOwner;
            Status = reqStatus;
            Title = title;
        }

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

        public int RequestId { get; set; } = 0;
        public UserModel RequestOwner { get; set; } = new UserModel();

        public RequestStatus Status { get; set; } = RequestStatus.New;
        public string Title { get; set; } = string.Empty;
    }
}
