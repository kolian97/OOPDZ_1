using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOPDZ_1
{
    public class FamalyMembers
    {
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string FullName { get; set; }
        public FamalyMembers Mother { get; set; }
        public FamalyMembers Father { get; set; }
        public FamalyMembers[] GetGrandMotherName()
        {
            return new FamalyMembers[] { Mother?.Mother, Father?.Mother };
        }
        public FamalyMembers[] GetGrandFatherName()
        {
            return new FamalyMembers[] { Father?.Father, Mother?.Father };
        }
        public FamalyMembers[] GetParentsName()
        {
            return new FamalyMembers[] { Father, Mother };
        }

    }
    public enum Gender { man, woman }
}
