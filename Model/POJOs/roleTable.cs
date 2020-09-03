using Project.Models.DAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.POJOs
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class roleTable
    {

        public int id { get; set; }
        public string role_name { get; set; }
    }
}
