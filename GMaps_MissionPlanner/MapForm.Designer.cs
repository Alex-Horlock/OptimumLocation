namespace whereToLive
{
    partial class MapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapForm));
            this.myMap = new GMap.NET.WindowsForms.GMapControl();
            this.mapContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DestinationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commuteDistanceKmLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addDestionationButton = new System.Windows.Forms.Button();
            this.destinationIDTextBox = new System.Windows.Forms.TextBox();
            this.visitsPerWeekMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mainMenuToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapContextMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // myMap
            // 
            this.myMap.Bearing = 0F;
            this.myMap.CanDragMap = true;
            this.myMap.ContextMenuStrip = this.mapContextMenuStrip;
            this.myMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.myMap.GrayScaleMode = false;
            this.myMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.myMap.LevelsKeepInMemmory = 5;
            this.myMap.Location = new System.Drawing.Point(249, 0);
            this.myMap.MarkersEnabled = true;
            this.myMap.MaxZoom = 18;
            this.myMap.MinZoom = 2;
            this.myMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.myMap.Name = "myMap";
            this.myMap.NegativeMode = false;
            this.myMap.PolygonsEnabled = true;
            this.myMap.RetryLoadTile = 0;
            this.myMap.RoutesEnabled = true;
            this.myMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.myMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.myMap.ShowTileGridLines = false;
            this.myMap.Size = new System.Drawing.Size(924, 536);
            this.myMap.TabIndex = 0;
            this.myMap.Zoom = 12D;
            this.myMap.OnMarkerEnter += new GMap.NET.WindowsForms.MarkerEnter(this.myMap_OnMarkerEnter);
            this.myMap.OnMarkerLeave += new GMap.NET.WindowsForms.MarkerLeave(this.myMap_OnMarkerLeave);
            this.myMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.myMap_MouseMove);
            // 
            // mapContextMenuStrip
            // 
            this.mapContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.mapContextMenuStrip.Name = "mapContextMenuStrip";
            this.mapContextMenuStrip.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.commuteDistanceKmLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addDestionationButton);
            this.panel1.Controls.Add(this.destinationIDTextBox);
            this.panel1.Controls.Add(this.visitsPerWeekMaskedTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 536);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Destination List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DestinationId,
            this.Frequency});
            this.dataGridView1.Location = new System.Drawing.Point(4, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(242, 241);
            this.dataGridView1.TabIndex = 7;
            // 
            // DestinationId
            // 
            this.DestinationId.HeaderText = "Id";
            this.DestinationId.Name = "DestinationId";
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Freq";
            this.Frequency.Name = "Frequency";
            // 
            // commuteDistanceKmLabel
            // 
            this.commuteDistanceKmLabel.AutoSize = true;
            this.commuteDistanceKmLabel.BackColor = System.Drawing.Color.Yellow;
            this.commuteDistanceKmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commuteDistanceKmLabel.Location = new System.Drawing.Point(21, 218);
            this.commuteDistanceKmLabel.Name = "commuteDistanceKmLabel";
            this.commuteDistanceKmLabel.Size = new System.Drawing.Size(15, 16);
            this.commuteDistanceKmLabel.TabIndex = 6;
            this.commuteDistanceKmLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Commute Distance (Km)";
            // 
            // addDestionationButton
            // 
            this.addDestionationButton.Location = new System.Drawing.Point(15, 146);
            this.addDestionationButton.Name = "addDestionationButton";
            this.addDestionationButton.Size = new System.Drawing.Size(100, 23);
            this.addDestionationButton.TabIndex = 4;
            this.addDestionationButton.Text = "Add Destination";
            this.addDestionationButton.UseVisualStyleBackColor = true;
            this.addDestionationButton.Click += new System.EventHandler(this.addDestionationButton_Click);
            // 
            // destinationIDTextBox
            // 
            this.destinationIDTextBox.Location = new System.Drawing.Point(15, 39);
            this.destinationIDTextBox.Name = "destinationIDTextBox";
            this.destinationIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.destinationIDTextBox.TabIndex = 3;
            this.destinationIDTextBox.Text = "X";
            // 
            // visitsPerWeekMaskedTextBox
            // 
            this.visitsPerWeekMaskedTextBox.Location = new System.Drawing.Point(15, 104);
            this.visitsPerWeekMaskedTextBox.Name = "visitsPerWeekMaskedTextBox";
            this.visitsPerWeekMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.visitsPerWeekMaskedTextBox.TabIndex = 2;
            this.visitsPerWeekMaskedTextBox.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visits (per week)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripDropDownButton});
            this.toolStrip1.Location = new System.Drawing.Point(249, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(924, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mainMenuToolStripDropDownButton
            // 
            this.mainMenuToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mainMenuToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.mainMenuToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("mainMenuToolStripDropDownButton.Image")));
            this.mainMenuToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainMenuToolStripDropDownButton.Name = "mainMenuToolStripDropDownButton";
            this.mainMenuToolStripDropDownButton.Size = new System.Drawing.Size(54, 22);
            this.mainMenuToolStripDropDownButton.Text = "Menu";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load ";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 536);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.myMap);
            this.Controls.Add(this.panel1);
            this.Name = "MapForm";
            this.Text = "Where To Live  (Version 1.0)";
            this.mapContextMenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl myMap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addDestionationButton;
        private System.Windows.Forms.TextBox destinationIDTextBox;
        private System.Windows.Forms.MaskedTextBox visitsPerWeekMaskedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label commuteDistanceKmLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton mainMenuToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip mapContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

