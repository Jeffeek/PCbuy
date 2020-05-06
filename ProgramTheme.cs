using System;
using System.Runtime.Serialization;

namespace TRPO_Project
{
    [DataContract]
    public class ProgramTheme
    {
        [DataMember]
        public string Theme { set; get; }

        [DataMember]
        public int UserID { get; set; }
        public ProgramTheme(string theme, int ID)
        {
            if (string.IsNullOrEmpty(theme) && theme != "Light" && theme != "Dark")
            {
                throw new Exception("THEME SET ERROR");
            }
            if (ID < 1)
            {
                throw new Exception("THEME ID SET ERROR");
            }
            Theme = theme;
            UserID = ID;
        }

        public override string ToString()
        {
            return $"[{UserID}:{Theme}]";
        }
    }
}
