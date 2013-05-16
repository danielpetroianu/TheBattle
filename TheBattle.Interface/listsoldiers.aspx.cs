using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheBattle.Model;
using TheBattle.Model.Repositories;
using TheBattle.Model.Entities;

namespace TheBattle.Interface
{
    public partial class listsoldiers : System.Web.UI.Page
    {
        private SoldierRepository _repository = new SoldierRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            soldiers.DataSource = _repository.GetAll().ToList();
            soldiers.DataBind();

        }
    }
}