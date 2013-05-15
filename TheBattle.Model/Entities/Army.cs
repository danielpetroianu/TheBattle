using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace TheBattle.Model.Entities
{
    public class Army : DbBase.DbEntity<int>
    {
        public Army()
        {
            Soldiers = new List<Soldier>();
        }

        public virtual List<Soldier> Soldiers 
        { 
            get; 
            set; 
        }

        public Soldier FrontMan
        {
            get 
            {
               var theCapitan = Soldiers.Find(s => s.IsCaptain == true);
                if(theCapitan == null)
                    theCapitan = Soldiers.FirstOrDefault();
                
                return theCapitan;
            }
        }

        public bool StartWarWith(Army defendingArmy)
        {
            if (this.FrontMan == null)
                return false;

            if (defendingArmy.FrontMan == null)
                return true;
            

            if (this.FrontMan.Fight(defendingArmy.FrontMan) == Soldier.FightOutcome.Win)
            {
                defendingArmy.ReportCasualty(defendingArmy.FrontMan);
            }
            else
            {
                this.ReportCasualty(this.FrontMan);
            }

            return this.StartWarWith(defendingArmy);
        }

        public void ReportCasualty(Soldier soldier)
        {
            if (this.Soldiers.Contains(soldier))
            {
                this.Soldiers.Remove(soldier);
            }
        }
    }
}
