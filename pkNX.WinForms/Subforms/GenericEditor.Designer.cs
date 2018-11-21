﻿namespace pkNX.WinForms
{
    partial class GenericEditor<T>
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
            this.Grid = new System.Windows.Forms.PropertyGrid();
            this.B_Save = new System.Windows.Forms.Button();
            this.CB_EntryName = new System.Windows.Forms.ComboBox();
            this.B_Dump = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // propertyGrid1
            //
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(461, 494);
            this.Grid.TabIndex = 0;
            //
            // B_Save
            //
            this.B_Save.Location = new System.Drawing.Point(386, 0);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(75, 23);
            this.B_Save.TabIndex = 1;
            this.B_Save.Text = "Save";
            this.B_Save.UseVisualStyleBackColor = true;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            //
            // CB_EntryName
            //
            this.CB_EntryName.FormattingEnabled = true;
            this.CB_EntryName.Location = new System.Drawing.Point(140, 0);
            this.CB_EntryName.Name = "CB_EntryName";
            this.CB_EntryName.Size = new System.Drawing.Size(152, 21);
            this.CB_EntryName.TabIndex = 2;
            this.CB_EntryName.SelectedIndexChanged += new System.EventHandler(this.CB_EntryName_SelectedIndexChanged);
            //
            // B_Dump
            //
            this.B_Dump.Location = new System.Drawing.Point(305, 0);
            this.B_Dump.Name = "B_Dump";
            this.B_Dump.Size = new System.Drawing.Size(75, 23);
            this.B_Dump.TabIndex = 3;
            this.B_Dump.Text = "Dump";
            this.B_Dump.UseVisualStyleBackColor = true;
            this.B_Dump.Click += new System.EventHandler(this.B_Dump_Click);
            //
            // GenericEditor
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 494);
            this.Controls.Add(this.B_Dump);
            this.Controls.Add(this.CB_EntryName);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.Grid);
            this.Name = "GenericEditor";
            this.Text = "GenericEditor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid Grid;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.ComboBox CB_EntryName;
        private System.Windows.Forms.Button B_Dump;
    }
}