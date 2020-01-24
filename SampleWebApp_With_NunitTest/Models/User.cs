using System;
using System.Collections.Generic;
using System.Text;

namespace SampleWebApp_With_NunitTest.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public bool? IsActive { get; set; }
    }
}
