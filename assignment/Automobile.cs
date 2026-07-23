using System.ComponentModel.DataAnnotations;

namespace _22_July_Assign.Models
{
    public class Automobile
    {
        
            public int Vehicle_Id { get; set; }

            [Required(ErrorMessage = "Name is mandatory")]
        [StringLength (65,MinimumLength =3,ErrorMessage ="Enetr proper vehicle name")]
            public string Vehicle_Name { get; set; }

        [Required(ErrorMessage = "Brand is mandatory")]

        public string Brand { get; set; }

            [Required(ErrorMessage = "Model Year is mandatory")]
            public string Model_Year { get; set; }

            [Required(ErrorMessage = "Stock is mandatory")]
        [Range(150000,10000000,ErrorMessage ="The price should be between 150000 and 10000000")]
            public int Price { get; set; }
        
        
        [Required(ErrorMessage = "Fuel type is mandatory")]
        public string FuelType {  get; set; }



    }
    }


