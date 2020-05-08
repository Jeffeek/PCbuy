using System;
using System.Drawing;
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

        [DataMember]
        public Color BottomLeft { get; set; } = Color.Blue;

        [DataMember]
        public Color BottomRight { get; set; } = Color.Magenta;

        [DataMember]
        public Color TopLeft { get; set; } = Color.Plum;

        [DataMember]
        public Color TopRight { get; set; } = Color.Aqua;

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
            return $"[{UserID}:{Theme}]\n[BottomRight:{BottomRight}, BottomLeft:{BottomLeft}, TopRight:{TopRight}, TopLeft:{TopLeft}]";
        }
    }
}
