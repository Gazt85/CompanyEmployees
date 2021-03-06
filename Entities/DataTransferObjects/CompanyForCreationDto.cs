﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class CompanyForCreationDto
    {
        [Required(ErrorMessage = "Company name is a required field")]
        [MaxLength(ErrorMessage ="Maximum lenght for name is 60 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Company address is a required field")]
        [MaxLength(ErrorMessage = "Maximum lenght for address is 60 characters.")]
        public string Address { get; set; }
        public string Country { get; set; }
        public IEnumerable<EmployeeForCreationDto> Employees { get; set; }


    }
}
