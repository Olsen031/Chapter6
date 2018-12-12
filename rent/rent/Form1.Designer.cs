namespace rent
{
    partial class Form1
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
            this.txtFloorLocation = new System.Windows.Forms.TextBox();
            this.txtRooms = new System.Windows.Forms.TextBox();
            this.btnCalculateRooms = new System.Windows.Forms.Button();
            this.lblFloorLocation = new System.Windows.Forms.Label();
            this.lblRooms = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFloorLocation
            // 
            this.txtFloorLocation.Location = new System.Drawing.Point(189, 76);
            this.txtFloorLocation.Name = "txtFloorLocation";
            this.txtFloorLocation.Size = new System.Drawing.Size(100, 20);
            this.txtFloorLocation.TabIndex = 0;
            // 
            // txtRooms
            // 
            this.txtRooms.Location = new System.Drawing.Point(189, 143);
            this.txtRooms.Name = "txtRooms";
            this.txtRooms.Size = new System.Drawing.Size(100, 20);
            this.txtRooms.TabIndex = 1;
            // 
            // btnCalculateRooms
            // 
            this.btnCalculateRooms.Location = new System.Drawing.Point(200, 202);
            this.btnCalculateRooms.Name = "btnCalculateRooms";
            this.btnCalculateRooms.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateRooms.TabIndex = 2;
            this.btnCalculateRooms.Text = "Calculate";
            this.btnCalculateRooms.UseVisualStyleBackColor = true;
            this.btnCalculateRooms.Click += new System.EventHandler(this.btnCalculateRooms_Click);
            // 
            // lblFloorLocation
            // 
            this.lblFloorLocation.AutoSize = true;
            this.lblFloorLocation.Location = new System.Drawing.Point(36, 76);
            this.lblFloorLocation.Name = "lblFloorLocation";
            this.lblFloorLocation.Size = new System.Drawing.Size(74, 13);
            this.lblFloorLocation.TabIndex = 3;
            this.lblFloorLocation.Text = "Floor Location";
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Location = new System.Drawing.Point(36, 143);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(92, 13);
            this.lblRooms.TabIndex = 4;
            this.lblRooms.Text = "Number of Rooms";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResult.Location = new System.Drawing.Point(200, 228);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(75, 100);
            this.lblResult.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(200, 331);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 406);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblRooms);
            this.Controls.Add(this.lblFloorLocation);
            this.Controls.Add(this.btnCalculateRooms);
            this.Controls.Add(this.txtRooms);
            this.Controls.Add(this.txtFloorLocation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFloorLocation;
        private System.Windows.Forms.TextBox txtRooms;
        private System.Windows.Forms.Button btnCalculateRooms;
        private System.Windows.Forms.Label lblFloorLocation;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnClear;
    }
}

