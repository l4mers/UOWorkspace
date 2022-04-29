using System;
using System.Collections.Generic;
using System.Linq;
using Assistant;
using Ultima;
using System.Windows.Forms;

namespace RazorEnhance
{
    public partial class f_Railer : Form
    {
        public f_Railer()
        {
            InitializeComponent();
        }

        private void f_Railer_Load(object sender, EventArgs e)
        {

            public Rail rail = new Rail();
            public Player player = new Player();
        }

        private void bt_AddTile_Click(object sender, EventArgs e)
        {
            int x = Player.Position.X;
            int y = Player.Position.Y;
            Tile tile = new Tail(x, y);
            rail.AddPlayerTile(tile);
            tb_Tile.Text = tile.ToString();
        }
        private void tb_Tile_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class Rail : Tile
    {
        private List<Tile> Rail;

        public Rail()
        {
            Rail = new List<Tile>();
        }
        public method AddTile(int x, int y)
        {
            Tile tile = new Tile(x, y);
            Rail.Add(tile);
        }
        public Method AddPlayerTile(Tile pos)
        {
            Rail.Add(pos);
        }
        public method GetRail()
        {
            return Rail;
        }
    }
}