namespace RazorEnhance
{
    partial class f_Railer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_AddTile = new System.Windows.Forms.Button();
            this.tb_Tile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_AddTile
            // 
            this.bt_AddTile.Location = new System.Drawing.Point(105, 91);
            this.bt_AddTile.Name = "bt_AddTile";
            this.bt_AddTile.Size = new System.Drawing.Size(75, 23);
            this.bt_AddTile.TabIndex = 0;
            this.bt_AddTile.Text = "Add Tile";
            this.bt_AddTile.UseVisualStyleBackColor = true;
            this.bt_AddTile.Click += new System.EventHandler(this.bt_AddTile_Click);
            // 
            // tb_Tile
            // 
            this.tb_Tile.Location = new System.Drawing.Point(62, 26);
            this.tb_Tile.Name = "tb_Tile";
            this.tb_Tile.ReadOnly = true;
            this.tb_Tile.Size = new System.Drawing.Size(160, 23);
            this.tb_Tile.TabIndex = 1;
            this.tb_Tile.TextChanged += new System.EventHandler(this.tb_Tile_TextChanged);
            // 
            // f_Railer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 126);
            this.Controls.Add(this.tb_Tile);
            this.Controls.Add(this.bt_AddTile);
            this.Name = "f_Railer";
            this.Text = "Railer";
            this.Load += new System.EventHandler(this.f_Railer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_AddTile;
        private TextBox tb_Tile;
    }
}