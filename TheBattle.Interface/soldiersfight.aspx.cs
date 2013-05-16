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
    public partial class soldiersfight : System.Web.UI.Page
    {

        private SoldierRepository _repository = new SoldierRepository();
        protected void Page_Load(object sender, EventArgs e)
        {

            soldier1.DataSource = _repository.GetAll().ToList();
            soldier1.DataTextField = "Name";
            soldier1.DataValueField = "Id";
            soldier1.DataBind();

            soldier2.DataSource = _repository.GetAll().ToList();
            soldier2.DataTextField = "Name";
            soldier2.DataValueField = "Id";
            soldier2.DataBind();
        }
    }
}