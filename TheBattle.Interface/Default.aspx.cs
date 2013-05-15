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
    public partial class _Default : System.Web.UI.Page
    {
        private ArmyRepository _repository = new ArmyRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
           /* Army army = new Army("Big Army");
            army.Soldiers.Add(new Soldier("Soldier1"));
            army.Soldiers.Add(new Soldier("Soldier2"));
            army.Soldiers.Add(new Soldier("Soldier3"));*/
         //   _repository.Add(army).Save();

            ddl.DataSource = _repository.GetAll().ToList();
            ddl.DataTextField = "Name";
            ddl.DataValueField = "Id";
            ddl.DataBind();
         
        }
    }
}
