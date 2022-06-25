using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        
        public Catalog(string name, int neededRenovators,string project)
        {
            this.Name = name;
            this.NeededRenovators = neededRenovators;
            this.Project = project;
          this.Renovators = new List<Renovator>();
        }
        public List<Renovator> Renovators { get; private set; }
        public string  Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }
        public int Count => Renovators.Count;

        public string AddRenovator(Renovator renovator)
        {
            //should i first check the name or the capacity???
            if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type)) return "Invalid renovator's information.";
            if (this.NeededRenovators==0) return "Renovators are no more needed.";
            if (renovator.Rate > 350) return "Invalid renovator's rate.";
            Renovators.Add(renovator);
            NeededRenovators--;
            return $"Successfully added {renovator.Name} to the catalog.";
        }
        public bool RemoveRenovator(string name)
        {

            if (Renovators.Any(renovator => renovator.Name == name))
            {
                
                Renovator renovator = Renovators.First(renovator => renovator.Name == name);
                NeededRenovators++;
                return Renovators.Remove(renovator);
            }            
            return false ;          
        }
        public int RemoveRenovatorBySpecialty(string type)
        {
            int count = 0;
            for (int i = 0; i < Renovators.Count; i++)
            {
                if (Renovators[i].Type == type)
                {
                    count++;
                    Renovators.Remove(Renovators[i]);
                    i--;
                }
            }
            NeededRenovators += count;
            return count;
        }
        public Renovator HireRenovator(string name)
        {
            var hiredRenovator = Renovators.FirstOrDefault(x => x.Name == name);
            if (hiredRenovator != default)
            {
                hiredRenovator.Hired = true;
                return hiredRenovator;
            }
            else
            {
                return null;
            }
        }
      
        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> result = new List<Renovator>();
            for (int i = 0; i < Renovators.Count; i++)
            {
                if (Renovators[i].Days >= days)
                {
                    result.Add(Renovators[i]);
                }
            }
            return result; 
        }

        public string Report()
        {
            StringBuilder res = new StringBuilder();
            res.AppendLine($"Renovators available for Project {this.Project}:");
            for (int i = 0; i < Renovators.Count; i++)
            {
                if (!Renovators[i].Hired)
                {
                    res.Append(Renovators[i].ToString());
                    res.AppendLine();
                }
            }
            return res.ToString().TrimEnd();
        }

    }
}
