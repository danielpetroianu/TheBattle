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
    public partial class soldiers : System.Web.UI.Page
    {
        private SoldierRepository _repository = new SoldierRepository();
        private WeaponRepository _weapon = new WeaponRepository();
        protected void Page_Load(object sender, EventArgs e)
        {

            weapon_ddl.DataSource = _weapon.GetAll().ToList();
            weapon_ddl.DataTextField = "Name";
            weapon_ddl.DataValueField = "Id";
            weapon_ddl.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Soldier soldier = new Soldier(soldier_name.Text);
            int weapon_id = Convert.ToInt32(weapon_ddl.SelectedValue);
            Weapon w = _weapon.FindBy(weapon => weapon.Id == weapon_id).FirstOrDefault();
            soldier.Weapon = w;
            _repository.Add(soldier).Save();
        }
    }
}