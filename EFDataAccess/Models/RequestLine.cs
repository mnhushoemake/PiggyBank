namespace EFDataAccess.Models;

public class RequestLine
{
    public int RequestLineId { get; set; }
    public string ItemDescription { get; set; }

    public decimal UnitCost { get; set; }
    public decimal Quantity { get; set; }

    public decimal Tax { get; set; }


}