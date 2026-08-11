namespace _10_Aug_Assign.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public int CostumerId { get; set; }

        public Costumer Costumer { get; set; }

        public int VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }

        //public int StateId { get; set; }

        //public State? State { get; set; }

        public DateTime BookDate { get; set; }

        public int BPrice {  get; set; }    

        public string Quantity {  get; set; } 

        
    }
}
