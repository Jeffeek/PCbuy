using System;
using System.Drawing;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace TRPO_Project
{
    [DataContract]
    public class ProgramTheme
    {
        [DataMember] 
        public ETheme Theme { get; set; } = ETheme.Dark;

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

        /// <exception cref="T:System.Exception">при невалидном ID пользователя</exception>
        public ProgramTheme(ETheme theme, int id)
        {
            if (id < 1)
            {
                throw new Exception("THEME ID SET ERROR");
            }
            Theme = theme;
            UserID = id;
        }

        public override string ToString()
        {
            return $"[{UserID}:{(Theme == ETheme.Dark ? "Dark" : "Light")}]\n[BottomRight:{BottomRight}, BottomLeft:{BottomLeft}, TopRight:{TopRight}, TopLeft:{TopLeft}]";
        }
    }
}
