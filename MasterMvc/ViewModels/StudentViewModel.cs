using MasterMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterMvc.ViewModels
{
    public class StudentViewModel
    {
        public Student student { get; set; }
        public IEnumerable<Subjects> Subjects { get; set; }

    }
}