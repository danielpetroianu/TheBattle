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
        protected void Page_Load(object sender, EventArgs e)
        {
            Army army = new Army();
            army.Soldiers.Add(new Soldier("Soldier1"));
            army.Soldiers.Add(new Soldier("Soldier2"));
            army.Soldiers.Add(new Soldier("Soldier3"));

            new ArmyRepository().Add(army).Save();
        }
    }
}
