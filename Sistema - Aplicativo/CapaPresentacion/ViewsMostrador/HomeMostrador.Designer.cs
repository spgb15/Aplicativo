using System;
using System.Runtime.InteropServices;

namespace CapaPresentacion.ViewsMostrador
{
    partial class HomeMostrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeMostrador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHelp = new FontAwesome.Sharp.IconButton();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReports = new FontAwesome.Sharp.IconButton();
            this.btnInfo = new FontAwesome.Sharp.IconButton();
            this.btnPagos = new FontAwesome.Sharp.IconButton();
            this.btnPacientes = new FontAwesome.Sharp.IconButton();
            this.btnAgendamiento = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMinimized = new System.Windows.Forms.PictureBox();
            this.btnClosed = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.iconActive = new FontAwesome.Sharp.IconPictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconActive)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(99)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(421, 838);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnHelp);
            this.panel4.Controls.Add(this.btnLogOut);
            this.panel4.Controls.Add(this.lblEmail);
            this.panel4.Controls.Add(this.lblNombre);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(4, 636);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(413, 198);
            this.panel4.TabIndex = 2;
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.btnHelp.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btnHelp.IconColor = System.Drawing.Color.Black;
            this.btnHelp.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnHelp.IconSize = 15;
            this.btnHelp.Location = new System.Drawing.Point(17, 154);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(380, 37);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "Ayuda";
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogOut.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnLogOut.IconSize = 15;
            this.btnLogOut.Location = new System.Drawing.Point(17, 116);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(380, 37);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Cerrar Sesion";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Location = new System.Drawing.Point(31, 81);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Correo";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(31, 49);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(84, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Perfil";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReports);
            this.panel2.Controls.Add(this.btnInfo);
            this.panel2.Controls.Add(this.btnPagos);
            this.panel2.Controls.Add(this.btnPacientes);
            this.panel2.Controls.Add(this.btnAgendamiento);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 158);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.panel2.Size = new System.Drawing.Size(413, 478);
            this.panel2.TabIndex = 2;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReports.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.btnReports.IconColor = System.Drawing.Color.White;
            this.btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReports.IconSize = 32;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 373);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(413, 71);
            this.btnReports.TabIndex = 18;
            this.btnReports.Text = "Reportes";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInfo.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.btnInfo.IconColor = System.Drawing.Color.White;
            this.btnInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfo.IconSize = 32;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(0, 302);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(413, 71);
            this.btnInfo.TabIndex = 16;
            this.btnInfo.Text = "Informacion";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btnPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnPagos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPagos.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnPagos.IconColor = System.Drawing.Color.White;
            this.btnPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPagos.IconSize = 32;
            this.btnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.Location = new System.Drawing.Point(0, 231);
            this.btnPagos.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(413, 71);
            this.btnPagos.TabIndex = 15;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagos.UseVisualStyleBackColor = false;
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btnPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnPacientes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPacientes.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            this.btnPacientes.IconColor = System.Drawing.Color.White;
            this.btnPacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPacientes.IconSize = 32;
            this.btnPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.Location = new System.Drawing.Point(0, 160);
            this.btnPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(413, 71);
            this.btnPacientes.TabIndex = 14;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPacientes.UseVisualStyleBackColor = false;
            // 
            // btnAgendamiento
            // 
            this.btnAgendamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btnAgendamiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgendamiento.FlatAppearance.BorderSize = 0;
            this.btnAgendamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamiento.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAgendamiento.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgendamiento.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.btnAgendamiento.IconColor = System.Drawing.Color.White;
            this.btnAgendamiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgendamiento.IconSize = 32;
            this.btnAgendamiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendamiento.Location = new System.Drawing.Point(0, 89);
            this.btnAgendamiento.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgendamiento.Name = "btnAgendamiento";
            this.btnAgendamiento.Size = new System.Drawing.Size(413, 71);
            this.btnAgendamiento.TabIndex = 13;
            this.btnAgendamiento.Text = "Agendamiento de Citas";
            this.btnAgendamiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendamiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgendamiento.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.btnDashboard.IconColor = System.Drawing.Color.White;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 18);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(413, 71);
            this.btnDashboard.TabIndex = 12;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.btnMinimized);
            this.panel3.Controls.Add(this.btnClosed);
            this.panel3.Controls.Add(this.Title);
            this.panel3.Controls.Add(this.iconActive);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(421, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(998, 76);
            this.panel3.TabIndex = 1;
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimized.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimized.Image")));
            this.btnMinimized.Location = new System.Drawing.Point(933, 9);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(23, 22);
            this.btnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimized.TabIndex = 2;
            this.btnMinimized.TabStop = false;
            this.btnMinimized.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnClosed
            // 
            this.btnClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClosed.Image = ((System.Drawing.Image)(resources.GetObject("btnClosed.Image")));
            this.btnClosed.Location = new System.Drawing.Point(962, 9);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.Size = new System.Drawing.Size(25, 24);
            this.btnClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClosed.TabIndex = 0;
            this.btnClosed.TabStop = false;
            this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(84, 24);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(73, 23);
            this.Title.TabIndex = 1;
            this.Title.Text = "Titulo";
            // 
            // iconActive
            // 
            this.iconActive.BackColor = System.Drawing.SystemColors.ControlLight;
            this.iconActive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconActive.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconActive.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconActive.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconActive.IconSize = 39;
            this.iconActive.Location = new System.Drawing.Point(24, 15);
            this.iconActive.Margin = new System.Windows.Forms.Padding(4);
            this.iconActive.Name = "iconActive";
            this.iconActive.Size = new System.Drawing.Size(43, 39);
            this.iconActive.TabIndex = 0;
            this.iconActive.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(421, 76);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(998, 762);
            this.panel5.TabIndex = 2;
            // 
            // HomeMostrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 838);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeMostrador";
            this.Text = "HomeMostrador";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconActive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnInfo;
        private FontAwesome.Sharp.IconButton btnPagos;
        private FontAwesome.Sharp.IconButton btnPacientes;
        private FontAwesome.Sharp.IconButton btnAgendamiento;
        private FontAwesome.Sharp.IconButton btnReports;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnHelp;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNombre;
        private FontAwesome.Sharp.IconPictureBox iconActive;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox btnClosed;
        private System.Windows.Forms.PictureBox btnMinimized;
    }
}