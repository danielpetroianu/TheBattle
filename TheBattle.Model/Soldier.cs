using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace TheBattle.Model
{
    public class Soldier : DbBase.DbEntity<int>
    {
        public virtual Army Army { get; set; }

        [Required]
        [StringLength(50)]
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                if (string.IsNullOrEmpty(Name))
                {
                    Name = value;
                }
            }

        }

        public bool Captain
        {
            get;
            set;
        }


        public bool Fight(Soldier otherSoldier)
        {
            if (otherSoldier == null && otherSoldier == this)
            {
                throw new ArgumentException("Soldier exception");
            }
            
                Random r = new Random();
                int winner = r.Next(0, 2);
                if (winner == 0)
                    return false;
                else
                    return true;
         
        }
    }
}
