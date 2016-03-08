using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class SEDCMember
    {
        public virtual int ID { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }


        public virtual void GetDetails()
        {
            Console.WriteLine("id: {0}  Name: {1}  LastName: {2}" , ID , FirstName , LastName);
        }


        public virtual bool ScanIdCard(string id)
        {
            if (id == null || id == "")
                return false;
            else
            {
                return true;
            }
        }

        public virtual bool IsIdValid(string id)
        {
            int result;
            if (int.TryParse(id, out result))
                return true;
            else
                return false;
        }


    }

   
}
