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


            int soldier_id;
            try
            {
                soldier_id = Convert.ToInt32(Request.QueryString["id"]);
                Soldier soldier = _repository.FindBy(s => s.Id == soldier_id).FirstOrDefault();
                soldier_name.Text = soldier.Name;
                weapon_ddl.SelectedIndex = Convert.ToInt32(soldier.Weapon);
            }
            catch (Exception ex)
            { }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           

            int soldier_id = 0;
            try
            {
                soldier_id = Convert.ToInt32(Request.QueryString["id"]);
            }
            catch(Exception ex)
            {
                soldier_id = 0;
            }

            Soldier soldier ;
            int weapon_id = Convert.ToInt32(weapon_ddl.SelectedValue);
            if (soldier_id == 0)
            {
                soldier = new Soldier(soldier_name.Text);
                Weapon w = _weapon.FindBy(weapon => weapon.Id == weapon_id).FirstOrDefault();
                soldier.Weapon = w;
                _repository.Add(soldier).Save();

            }
            else
            {
                soldier = _repository.FindBy(s => s.Id == soldier_id).FirstOrDefault();
                Weapon w = _weapon.FindBy(weapon => weapon.Id == weapon_id).FirstOrDefault();
                soldier.Weapon = w;
                _repository.Update(soldier).Save(); 
            }
            Response.Redirect("listsoldiers.aspx");
        }
    }
}