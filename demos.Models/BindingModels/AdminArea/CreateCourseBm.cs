using System;

namespace demos.Models.BindingModels.Admin
{
  public class CreateCourseBm
    {
        //Name, Description, StartDate, EndDate,Treiner

        public string Name { get; set; }

        public string Description { get; set; }
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Treiner { get; set; }

        public int TreinerId { get; set; }

    }
}
