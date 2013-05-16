﻿using System;
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

        private ArmyRepository _repository = new ArmyRepository();
        protected void Page_Load(object sender, EventArgs e)
        {

            ddl.DataSource = _repository.GetAll().ToList();
            ddl.DataTextField = "Id";
            ddl.DataValueField = "Id";
            ddl.DataBind();
        }
    }
}