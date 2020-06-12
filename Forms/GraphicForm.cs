using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data.SQLite;
using System.Data.Sql;
using System.Runtime.Serialization.Json;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Components;
using System.Threading;
using TRPO_Project.Properties;
using Bunifu.Framework.Lib;
using BunifuAnimatorNS;
using Bunifu.Framework.UI;


namespace TRPO_Project
{
    public partial class GraphicForm : MetroForm, IThemeChange
    {
        private List<int> GRAPH_NODE = new List<int>();
        private Point lastPoint;

        public GraphicForm(MetroThemeStyle theme)
        {
            InitializeComponent();
            FormFadeTransition.ShowAsyc(this);
            this.Theme = theme;
            Graphic.BackGroundColor = this.Theme == MetroThemeStyle.Light ? Color.White : Color.FromArgb(17, 17, 17);
            FillGraphic();
        }

        private void bunifuImageButtonEXIT_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void FillGraphic()
        {
            using (SQLiteConnection sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\DataBases\\TRPO.db"))
            {
                sql_con.Open();
                using (var sql_cmd = new SQLiteCommand("SELECT PRICEall FROM Orders",sql_con))
                {
                    using (var reader = sql_cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GRAPH_NODE.Add(reader.GetInt32(0));
                        }
                    }
                }
            }
            Graphic.Items.Clear();
            Graphic.Items.AddRange(GRAPH_NODE);
        }

        private void bunifuImageButtonHIDE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region MovingForm
        private void panelHead_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
        }

        private void panelHead_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }
        #endregion

        public void ChangeMetroControls(ProgramTheme obj)
        {
            this.Theme = obj.Theme == ETheme.Dark ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
        }

        public void ChangeNonMetroControls(ProgramTheme obj)
        {
            panelHead.BackColor = obj.Theme == ETheme.Dark ? Color.FromArgb(17, 17, 17) : Color.White;
            Graphic.BackGroundColor = obj.Theme == ETheme.Dark ? Color.Black : Color.White;
            Graphic.LineColor = obj.Theme == ETheme.Dark ? Color.Orchid : Color.OrangeRed;
        }

        public async void ReadThemeAsync()
        {
            try
            {
                List<ProgramTheme> themes;
                using (FileStream file = new FileStream($"{Directory.GetCurrentDirectory()}\\ThemeModel\\ThemeSettings.json",
                    FileMode.OpenOrCreate))
                {
                    DataContractJsonSerializer jsonSerializer =
                        new DataContractJsonSerializer(typeof(List<ProgramTheme>));

                    themes = jsonSerializer.ReadObject(file) as List<ProgramTheme>;
                }

                if (themes.Count(x => x.UserID == 1) > 0)
                {
                    ProgramTheme ThemeOBJ = themes.Find(x => x.UserID == 1);
                    ChangeNonMetroControls(ThemeOBJ);
                    ChangeMetroControls(ThemeOBJ);
                    Refresh();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Произошла ошибка при дисериализации: \n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
