using Domain.Models.Events;

namespace Domain.Entities;

public class Address : Entity 
{

    public string Line1 {get; set;} = String.Empty;

    public string Line2 {get; set;} = String.Empty;

    public string City {get; set;} = String.Empty;

    public string State {get; set;} = String.Empty;

    public string Country {get; set;} = String.Empty;
    public string Zip {get; set;} = String.Empty;

    public Alumni? Alumni;
}