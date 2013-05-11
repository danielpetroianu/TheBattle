using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace TheBattle.Model
{
    public class Army
    {
        [Key]
        public int Id { get; set; }

        private List<Soldier> soldiers;

        public Army(int id)
        {
            this.Id = id;

            soldiers = new List<Soldier>();
        }

        public void addSoldier(Soldier soldier)
        {
            if (soldier != null)
            {
                soldiers.Add(soldier);
            }
            else
            {
                Console.WriteLine("Soldier passed is null");
            }
        }

        public List<Soldier> getAllSoldiers()
        {
            if (soldiers.Count == 0)
            {
                Console.WriteLine("List is Empty");
            }
            else if (soldiers == null)
            {
                Console.WriteLine("List is null, initializing to avoid nasty stuffs!");
                soldiers = new List<Soldier>();
            }

            return soldiers;
        }

    }
}
