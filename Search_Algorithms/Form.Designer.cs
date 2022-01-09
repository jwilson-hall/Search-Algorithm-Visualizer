
namespace Search_Algorithms
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.pnl_Grid = new System.Windows.Forms.Panel();
            this.btn_Start_Algo = new System.Windows.Forms.Button();
            this.Program_Timer = new System.Windows.Forms.Timer(this.components);
            this.updown_numCols = new System.Windows.Forms.NumericUpDown();
            this.btn_start_location = new System.Windows.Forms.Button();
            this.btn_end_location = new System.Windows.Forms.Button();
            this.btn_wall = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.lbl_ActiveBrush = new System.Windows.Forms.Label();
            this.btn_remove_path = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updown_numCols)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Grid
            // 
            this.pnl_Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Grid.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_Grid.Location = new System.Drawing.Point(158, 12);
            this.pnl_Grid.Name = "pnl_Grid";
            this.pnl_Grid.Size = new System.Drawing.Size(630, 426);
            this.pnl_Grid.TabIndex = 0;
            this.pnl_Grid.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Grid_Paint);
            this.pnl_Grid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Grid_MouseDown);
            this.pnl_Grid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Grid_MouseDown);
            this.pnl_Grid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Grid_MouseUp);
            // 
            // btn_Start_Algo
            // 
            this.btn_Start_Algo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Start_Algo.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Start_Algo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Start_Algo.FlatAppearance.BorderSize = 0;
            this.btn_Start_Algo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btn_Start_Algo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start_Algo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Start_Algo.Location = new System.Drawing.Point(12, 390);
            this.btn_Start_Algo.Name = "btn_Start_Algo";
            this.btn_Start_Algo.Size = new System.Drawing.Size(124, 48);
            this.btn_Start_Algo.TabIndex = 1;
            this.btn_Start_Algo.Text = "Start";
            this.btn_Start_Algo.UseVisualStyleBackColor = false;
            this.btn_Start_Algo.Click += new System.EventHandler(this.btn_Start_Algo_Click);
            // 
            // Program_Timer
            // 
            this.Program_Timer.Enabled = true;
            this.Program_Timer.Interval = 5;
            this.Program_Timer.Tick += new System.EventHandler(this.Program_Timer_Tick);
            // 
            // updown_numCols
            // 
            this.updown_numCols.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updown_numCols.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updown_numCols.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updown_numCols.Location = new System.Drawing.Point(16, 352);
            this.updown_numCols.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.updown_numCols.Name = "updown_numCols";
            this.updown_numCols.Size = new System.Drawing.Size(120, 19);
            this.updown_numCols.TabIndex = 2;
            this.updown_numCols.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.updown_numCols.ValueChanged += new System.EventHandler(this.updown_numCols_ValueChanged);
            // 
            // btn_start_location
            // 
            this.btn_start_location.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_start_location.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_start_location.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start_location.FlatAppearance.BorderSize = 0;
            this.btn_start_location.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_start_location.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start_location.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_start_location.Location = new System.Drawing.Point(12, 279);
            this.btn_start_location.Name = "btn_start_location";
            this.btn_start_location.Size = new System.Drawing.Size(124, 48);
            this.btn_start_location.TabIndex = 3;
            this.btn_start_location.Text = "Start Location";
            this.btn_start_location.UseVisualStyleBackColor = false;
            this.btn_start_location.Click += new System.EventHandler(this.btn_start_location_Click);
            // 
            // btn_end_location
            // 
            this.btn_end_location.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_end_location.BackColor = System.Drawing.Color.Firebrick;
            this.btn_end_location.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_end_location.FlatAppearance.BorderSize = 0;
            this.btn_end_location.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btn_end_location.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_end_location.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_end_location.Location = new System.Drawing.Point(12, 225);
            this.btn_end_location.Name = "btn_end_location";
            this.btn_end_location.Size = new System.Drawing.Size(124, 48);
            this.btn_end_location.TabIndex = 4;
            this.btn_end_location.Text = "End Location";
            this.btn_end_location.UseVisualStyleBackColor = false;
            this.btn_end_location.Click += new System.EventHandler(this.btn_end_location_Click);
            // 
            // btn_wall
            // 
            this.btn_wall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_wall.BackColor = System.Drawing.Color.DarkGray;
            this.btn_wall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_wall.FlatAppearance.BorderSize = 0;
            this.btn_wall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_wall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_wall.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_wall.Location = new System.Drawing.Point(12, 171);
            this.btn_wall.Name = "btn_wall";
            this.btn_wall.Size = new System.Drawing.Size(124, 48);
            this.btn_wall.TabIndex = 5;
            this.btn_wall.Text = "Wall";
            this.btn_wall.UseVisualStyleBackColor = false;
            this.btn_wall.Click += new System.EventHandler(this.btn_wall_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_remove.BackColor = System.Drawing.Color.DimGray;
            this.btn_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_remove.Location = new System.Drawing.Point(12, 117);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(124, 48);
            this.btn_remove.TabIndex = 6;
            this.btn_remove.Text = "Remove Tile";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // lbl_ActiveBrush
            // 
            this.lbl_ActiveBrush.AutoSize = true;
            this.lbl_ActiveBrush.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ActiveBrush.Location = new System.Drawing.Point(1, 3);
            this.lbl_ActiveBrush.Name = "lbl_ActiveBrush";
            this.lbl_ActiveBrush.Size = new System.Drawing.Size(96, 15);
            this.lbl_ActiveBrush.TabIndex = 7;
            this.lbl_ActiveBrush.Text = "Active Brush: ";
            // 
            // btn_remove_path
            // 
            this.btn_remove_path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_remove_path.BackColor = System.Drawing.Color.DimGray;
            this.btn_remove_path.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remove_path.FlatAppearance.BorderSize = 0;
            this.btn_remove_path.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_remove_path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove_path.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_remove_path.Location = new System.Drawing.Point(12, 85);
            this.btn_remove_path.Name = "btn_remove_path";
            this.btn_remove_path.Size = new System.Drawing.Size(124, 26);
            this.btn_remove_path.TabIndex = 8;
            this.btn_remove_path.Text = "Remove Path";
            this.btn_remove_path.UseVisualStyleBackColor = false;
            this.btn_remove_path.Click += new System.EventHandler(this.btn_remove_path_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_reset.BackColor = System.Drawing.Color.DimGray;
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_reset.Location = new System.Drawing.Point(12, 53);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(124, 26);
            this.btn_reset.TabIndex = 9;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_remove_path);
            this.Controls.Add(this.lbl_ActiveBrush);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_wall);
            this.Controls.Add(this.btn_end_location);
            this.Controls.Add(this.btn_start_location);
            this.Controls.Add(this.updown_numCols);
            this.Controls.Add(this.btn_Start_Algo);
            this.Controls.Add(this.pnl_Grid);
            this.Name = "Main";
            this.Text = "Search Algorithms";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Load += new System.EventHandler(this.Main_Load);
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.updown_numCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Grid;
        private System.Windows.Forms.Button btn_Start_Algo;
        private System.Windows.Forms.Timer Program_Timer;
        private System.Windows.Forms.NumericUpDown updown_numCols;
        private System.Windows.Forms.Button btn_start_location;
        private System.Windows.Forms.Button btn_end_location;
        private System.Windows.Forms.Button btn_wall;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label lbl_ActiveBrush;
        private System.Windows.Forms.Button btn_remove_path;
        private System.Windows.Forms.Button btn_reset;
    }
}

