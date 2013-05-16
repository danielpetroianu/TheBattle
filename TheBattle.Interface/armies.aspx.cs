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
    public partial class armies : System.Web.UI.Page
    {
        private ArmyRepository _armyRepository = new ArmyRepository();
        private SoldierRepository _soldierRepo = new SoldierRepository();


        protected void Page_Load(object sender, EventArgs e)
        {

            var freeSoldiers = _soldierRepo.FindBy(soldier => soldier.Army == null).ToList();

            if (freeSoldiers.Count > 0)
            {
                noSoldiersMessage.Visible = false;

                availableSoldiersList.DataSource = _soldierRepo.FindBy(soldier => soldier.Army == null).ToList();
                availableSoldiersList.DataTextField = "Name";
                availableSoldiersList.DataValueField = "Id";
                availableSoldiersList.DataBind();
            }
            else
            {
                noSoldiersMessage.Visible = true;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var selectedSoldiers = availableSoldiersList.Items.Cast<ListItem>().Where(x => x.Selected);

            var soldiers = new List<Soldier>();
            foreach (ListItem li in selectedSoldiers)
            {
                int soldierId = Convert.ToInt32(li.Value);
                _soldierRepo.FindBy(s=> s.Id == soldierId);
            }

            var army = new Army(armyName.Text);
            army.Soldiers = soldiers;

            _armyRepository.Add(army).Save();

            Page.Response.RedirectPermanent("~/Default.aspx");
        }
    }
}