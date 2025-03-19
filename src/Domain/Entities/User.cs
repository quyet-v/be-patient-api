﻿using System.ComponentModel.DataAnnotations;

namespace be_patient_api;

public class User
{
    [Key]
    public int Id {get; set;}

    public string FirstName {get; set;}

    public string LastName {get; set;}
}
