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
    public partial class GraphicForm : MetroForm
    {
        private List<int> GRAPH_NODE = new List<int>();
        public GraphicForm()
        {
            InitializeComponent();
            FormFadeTransition.ShowAsyc(this);
            FillGraphic();
        }

        private void bunifuImageButtonEXIT_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void FillGraphic()
        {
            using (SQLiteConnection sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}TRPO.db"))
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
    }
}
