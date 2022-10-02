using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MVC_Assignment.Models
{
    public class Feedback
    {
       

        [Required(ErrorMessage = "EmpName is Required")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Gender selection is Required")]
        public string Gender { get; set; }



        [Required(ErrorMessage = "Selection of Subject is Required")]
        public String Courses
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Rating is Compulsory")]
        public string Ratings { get; set; }
        [Required(ErrorMessage = "Mention Your Suggestions")]
        public string Suggestions { get; set; }


    }
}