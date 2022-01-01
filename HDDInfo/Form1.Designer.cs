namespace HDDInfo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbHdd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblPartitions = new System.Windows.Forms.Label();
            this.lblSignature = new System.Windows.Forms.Label();
            this.lblCylinders = new System.Windows.Forms.Label();
            this.lblSectors = new System.Windows.Forms.Label();
            this.lblTracks = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblHeads = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblBytesPerSect = new System.Windows.Forms.Label();
            this.lblSectorsPerTrack = new System.Windows.Forms.Label();
            this.lblTracksPerCyl = new System.Windows.Forms.Label();
            this.lblInterface = new System.Windows.Forms.Label();
            this.lblFirmware = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HDDInfo.Properties.Resources.HDDIcon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmbHdd
            // 
            this.cmbHdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHdd.FormattingEnabled = true;
            this.cmbHdd.Location = new System.Drawing.Point(53, 27);
            this.cmbHdd.Name = "cmbHdd";
            this.cmbHdd.Size = new System.Drawing.Size(304, 21);
            this.cmbHdd.TabIndex = 2;
            this.cmbHdd.SelectedIndexChanged += new System.EventHandler(this.cmbHdd_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select the drive:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(12, 87);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Model:";
            // 
            // lblPartitions
            // 
            this.lblPartitions.AutoSize = true;
            this.lblPartitions.Location = new System.Drawing.Point(12, 182);
            this.lblPartitions.Name = "lblPartitions";
            this.lblPartitions.Size = new System.Drawing.Size(53, 13);
            this.lblPartitions.TabIndex = 5;
            this.lblPartitions.Text = "Partitions:";
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Location = new System.Drawing.Point(12, 205);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(55, 13);
            this.lblSignature.TabIndex = 6;
            this.lblSignature.Text = "Signature:";
            // 
            // lblCylinders
            // 
            this.lblCylinders.AutoSize = true;
            this.lblCylinders.Location = new System.Drawing.Point(12, 268);
            this.lblCylinders.Name = "lblCylinders";
            this.lblCylinders.Size = new System.Drawing.Size(52, 13);
            this.lblCylinders.TabIndex = 7;
            this.lblCylinders.Text = "Cylinders:";
            // 
            // lblSectors
            // 
            this.lblSectors.AutoSize = true;
            this.lblSectors.Location = new System.Drawing.Point(12, 292);
            this.lblSectors.Name = "lblSectors";
            this.lblSectors.Size = new System.Drawing.Size(46, 13);
            this.lblSectors.TabIndex = 8;
            this.lblSectors.Text = "Sectors:";
            // 
            // lblTracks
            // 
            this.lblTracks.AutoSize = true;
            this.lblTracks.Location = new System.Drawing.Point(179, 292);
            this.lblTracks.Name = "lblTracks";
            this.lblTracks.Size = new System.Drawing.Size(43, 13);
            this.lblTracks.TabIndex = 9;
            this.lblTracks.Text = "Tracks:";
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Location = new System.Drawing.Point(12, 111);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(46, 13);
            this.lblSerial.TabIndex = 10;
            this.lblSerial.Text = "Serial #:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 64);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Type:";
            // 
            // lblHeads
            // 
            this.lblHeads.AutoSize = true;
            this.lblHeads.Location = new System.Drawing.Point(181, 268);
            this.lblHeads.Name = "lblHeads";
            this.lblHeads.Size = new System.Drawing.Size(41, 13);
            this.lblHeads.TabIndex = 12;
            this.lblHeads.Text = "Heads:";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(12, 158);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(51, 13);
            this.lblCapacity.TabIndex = 13;
            this.lblCapacity.Text = "Capacity:";
            // 
            // lblBytesPerSect
            // 
            this.lblBytesPerSect.AutoSize = true;
            this.lblBytesPerSect.Location = new System.Drawing.Point(12, 329);
            this.lblBytesPerSect.Name = "lblBytesPerSect";
            this.lblBytesPerSect.Size = new System.Drawing.Size(88, 13);
            this.lblBytesPerSect.TabIndex = 14;
            this.lblBytesPerSect.Text = "Bytes per Sector:";
            // 
            // lblSectorsPerTrack
            // 
            this.lblSectorsPerTrack.AutoSize = true;
            this.lblSectorsPerTrack.Location = new System.Drawing.Point(12, 353);
            this.lblSectorsPerTrack.Name = "lblSectorsPerTrack";
            this.lblSectorsPerTrack.Size = new System.Drawing.Size(95, 13);
            this.lblSectorsPerTrack.TabIndex = 15;
            this.lblSectorsPerTrack.Text = "Sectors per Track:";
            // 
            // lblTracksPerCyl
            // 
            this.lblTracksPerCyl.AutoSize = true;
            this.lblTracksPerCyl.Location = new System.Drawing.Point(12, 376);
            this.lblTracksPerCyl.Name = "lblTracksPerCyl";
            this.lblTracksPerCyl.Size = new System.Drawing.Size(101, 13);
            this.lblTracksPerCyl.TabIndex = 16;
            this.lblTracksPerCyl.Text = "Tracks per Cylinder:";
            // 
            // lblInterface
            // 
            this.lblInterface.AutoSize = true;
            this.lblInterface.Location = new System.Drawing.Point(12, 134);
            this.lblInterface.Name = "lblInterface";
            this.lblInterface.Size = new System.Drawing.Size(52, 13);
            this.lblInterface.TabIndex = 17;
            this.lblInterface.Text = "Interface:";
            // 
            // lblFirmware
            // 
            this.lblFirmware.AutoSize = true;
            this.lblFirmware.Location = new System.Drawing.Point(12, 229);
            this.lblFirmware.Name = "lblFirmware";
            this.lblFirmware.Size = new System.Drawing.Size(52, 13);
            this.lblFirmware.TabIndex = 18;
            this.lblFirmware.Text = "Firmware:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 408);
            this.Controls.Add(this.lblFirmware);
            this.Controls.Add(this.lblInterface);
            this.Controls.Add(this.lblTracksPerCyl);
            this.Controls.Add(this.lblSectorsPerTrack);
            this.Controls.Add(this.lblBytesPerSect);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblHeads);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblSerial);
            this.Controls.Add(this.lblTracks);
            this.Controls.Add(this.lblSectors);
            this.Controls.Add(this.lblCylinders);
            this.Controls.Add(this.lblSignature);
            this.Controls.Add(this.lblPartitions);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHdd);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "HDD Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbHdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblPartitions;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.Label lblCylinders;
        private System.Windows.Forms.Label lblSectors;
        private System.Windows.Forms.Label lblTracks;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblHeads;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblBytesPerSect;
        private System.Windows.Forms.Label lblSectorsPerTrack;
        private System.Windows.Forms.Label lblTracksPerCyl;
        private System.Windows.Forms.Label lblInterface;
        private System.Windows.Forms.Label lblFirmware;
    }
}

