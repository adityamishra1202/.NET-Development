using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _30_July_Assign.Models
{
    public class Employee
    {
        public int Employee_ID {get;set;}

        [Required(ErrorMessage ="first Name is mandatory")]
public string First_Name { get; set; }
        [Required(ErrorMessage = "Last Name is mandatory")]
        public string Last_Name {  get; set; }

        [Required(ErrorMessage ="Email is must")]
        [EmailAddress(ErrorMessage ="Invalid email Login")]
public string Email {  get; set; }  


public long Mobile_Number {  get; set; }    
public string DOB {  get; set; }    
public char Gender {  get; set; }    
public int Salary {  get; set; }
        [Required(ErrorMessage = "Date of joining should be mentioned")]
        public string Date_of_Joining {  get; set; }
        [Required(ErrorMessage = "Enter Department")]
        public string	Department {  get; set; }   
public string 	Designation {  get; set; }  
public string Employment_Status {  get; set; }  //Active inactive

    }
}
