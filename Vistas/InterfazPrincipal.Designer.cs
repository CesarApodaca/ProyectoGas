namespace ProyectoGas
{
    partial class InterfazPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PipasDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAsignarChofer = new System.Windows.Forms.ToolStripMenuItem();
            this.dispositivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.btnChoferes = new System.Windows.Forms.Button();
            this.btnPipa = new System.Windows.Forms.Button();
            this.btnTanques = new System.Windows.Forms.Button();
            this.panelDisp = new System.Windows.Forms.Panel();
            this.dropDisp = new System.Windows.Forms.Label();
            this.btnDesasigDisp = new System.Windows.Forms.Button();
            this.btnAsigDisp = new System.Windows.Forms.Button();
            this.btnAltaDisp = new System.Windows.Forms.Button();
            this.btnDisp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.panelDisp.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.PipasDeToolStripMenuItem,
            this.dispositivosToolStripMenuItem,
            this.acercaDeToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(111, 26);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.ayudaToolStripMenuItem.Text = "Opciones";
            // 
            // PipasDeToolStripMenuItem
            // 
            this.PipasDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAsignarChofer});
            this.PipasDeToolStripMenuItem.Name = "PipasDeToolStripMenuItem";
            this.PipasDeToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.PipasDeToolStripMenuItem.Text = "Pipas";
            // 
            // btnAsignarChofer
            // 
            this.btnAsignarChofer.Name = "btnAsignarChofer";
            this.btnAsignarChofer.Size = new System.Drawing.Size(180, 26);
            this.btnAsignarChofer.Text = "Asignar chofer";
            this.btnAsignarChofer.Click += new System.EventHandler(this.btnAsignarChofer_Click);
            // 
            // dispositivosToolStripMenuItem
            // 
            this.dispositivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignaciónToolStripMenuItem});
            this.dispositivosToolStripMenuItem.Name = "dispositivosToolStripMenuItem";
            this.dispositivosToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.dispositivosToolStripMenuItem.Text = "Dispositivos";
            // 
            // asignaciónToolStripMenuItem
            // 
            this.asignaciónToolStripMenuItem.Name = "asignaciónToolStripMenuItem";
            this.asignaciónToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.asignaciónToolStripMenuItem.Text = "Asignación";
            this.asignaciónToolStripMenuItem.Click += new System.EventHandler(this.asignaciónToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem1
            // 
            this.acercaDeToolStripMenuItem1.Name = "acercaDeToolStripMenuItem1";
            this.acercaDeToolStripMenuItem1.Size = new System.Drawing.Size(87, 24);
            this.acercaDeToolStripMenuItem1.Text = "Acerca de";
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(90)))));
            this.sidePanel.Controls.Add(this.button7);
            this.sidePanel.Controls.Add(this.btnChoferes);
            this.sidePanel.Controls.Add(this.btnPipa);
            this.sidePanel.Controls.Add(this.btnTanques);
            this.sidePanel.Controls.Add(this.panelDisp);
            this.sidePanel.Controls.Add(this.button2);
            this.sidePanel.Controls.Add(this.button1);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 28);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(210, 693);
            this.sidePanel.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 635);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(210, 58);
            this.button7.TabIndex = 13;
            this.button7.Text = "Salir";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnChoferes
            // 
            this.btnChoferes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChoferes.FlatAppearance.BorderSize = 0;
            this.btnChoferes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoferes.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoferes.ForeColor = System.Drawing.Color.White;
            this.btnChoferes.Image = ((System.Drawing.Image)(resources.GetObject("btnChoferes.Image")));
            this.btnChoferes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChoferes.Location = new System.Drawing.Point(0, 288);
            this.btnChoferes.Name = "btnChoferes";
            this.btnChoferes.Size = new System.Drawing.Size(210, 58);
            this.btnChoferes.TabIndex = 12;
            this.btnChoferes.Text = "Choferes";
            this.btnChoferes.UseVisualStyleBackColor = true;
            this.btnChoferes.Click += new System.EventHandler(this.btnChoferes_Click);
            // 
            // btnPipa
            // 
            this.btnPipa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPipa.FlatAppearance.BorderSize = 0;
            this.btnPipa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPipa.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPipa.ForeColor = System.Drawing.Color.White;
            this.btnPipa.Image = ((System.Drawing.Image)(resources.GetObject("btnPipa.Image")));
            this.btnPipa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPipa.Location = new System.Drawing.Point(0, 230);
            this.btnPipa.Name = "btnPipa";
            this.btnPipa.Size = new System.Drawing.Size(210, 58);
            this.btnPipa.TabIndex = 11;
            this.btnPipa.Text = "Pipas";
            this.btnPipa.UseVisualStyleBackColor = true;
            this.btnPipa.Click += new System.EventHandler(this.btnPipa_Click);
            // 
            // btnTanques
            // 
            this.btnTanques.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTanques.FlatAppearance.BorderSize = 0;
            this.btnTanques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTanques.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTanques.ForeColor = System.Drawing.Color.White;
            this.btnTanques.Image = ((System.Drawing.Image)(resources.GetObject("btnTanques.Image")));
            this.btnTanques.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTanques.Location = new System.Drawing.Point(0, 172);
            this.btnTanques.Name = "btnTanques";
            this.btnTanques.Size = new System.Drawing.Size(210, 58);
            this.btnTanques.TabIndex = 10;
            this.btnTanques.Text = "Tanques";
            this.btnTanques.UseVisualStyleBackColor = true;
            this.btnTanques.Click += new System.EventHandler(this.btnTanques_Click);
            // 
            // panelDisp
            // 
            this.panelDisp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(90)))));
            this.panelDisp.Controls.Add(this.dropDisp);
            this.panelDisp.Controls.Add(this.btnDesasigDisp);
            this.panelDisp.Controls.Add(this.btnAsigDisp);
            this.panelDisp.Controls.Add(this.btnAltaDisp);
            this.panelDisp.Controls.Add(this.btnDisp);
            this.panelDisp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDisp.Location = new System.Drawing.Point(0, 116);
            this.panelDisp.Name = "panelDisp";
            this.panelDisp.Size = new System.Drawing.Size(210, 56);
            this.panelDisp.TabIndex = 15;
            // 
            // dropDisp
            // 
            this.dropDisp.AutoSize = true;
            this.dropDisp.Image = ((System.Drawing.Image)(resources.GetObject("dropDisp.Image")));
            this.dropDisp.Location = new System.Drawing.Point(165, 21);
            this.dropDisp.Name = "dropDisp";
            this.dropDisp.Size = new System.Drawing.Size(24, 17);
            this.dropDisp.TabIndex = 16;
            this.dropDisp.Text = "    ";
            this.dropDisp.Click += new System.EventHandler(this.dropDisp_Click);
            this.dropDisp.MouseEnter += new System.EventHandler(this.dropDisp_MouseEnter);
            this.dropDisp.MouseLeave += new System.EventHandler(this.dropDisp_MouseLeave);
            // 
            // btnDesasigDisp
            // 
            this.btnDesasigDisp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(90)))));
            this.btnDesasigDisp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDesasigDisp.FlatAppearance.BorderSize = 0;
            this.btnDesasigDisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesasigDisp.Font = new System.Drawing.Font("Segoe UI Semilight", 9.8F);
            this.btnDesasigDisp.ForeColor = System.Drawing.Color.White;
            this.btnDesasigDisp.Image = ((System.Drawing.Image)(resources.GetObject("btnDesasigDisp.Image")));
            this.btnDesasigDisp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesasigDisp.Location = new System.Drawing.Point(0, 138);
            this.btnDesasigDisp.Name = "btnDesasigDisp";
            this.btnDesasigDisp.Size = new System.Drawing.Size(210, 40);
            this.btnDesasigDisp.TabIndex = 23;
            this.btnDesasigDisp.Text = "Desasignación";
            this.btnDesasigDisp.UseVisualStyleBackColor = false;
            this.btnDesasigDisp.Click += new System.EventHandler(this.btnDesasigDisp_Click);
            // 
            // btnAsigDisp
            // 
            this.btnAsigDisp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(90)))));
            this.btnAsigDisp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsigDisp.FlatAppearance.BorderSize = 0;
            this.btnAsigDisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsigDisp.Font = new System.Drawing.Font("Segoe UI Semilight", 9.8F);
            this.btnAsigDisp.ForeColor = System.Drawing.Color.White;
            this.btnAsigDisp.Image = ((System.Drawing.Image)(resources.GetObject("btnAsigDisp.Image")));
            this.btnAsigDisp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsigDisp.Location = new System.Drawing.Point(0, 98);
            this.btnAsigDisp.Name = "btnAsigDisp";
            this.btnAsigDisp.Size = new System.Drawing.Size(210, 40);
            this.btnAsigDisp.TabIndex = 22;
            this.btnAsigDisp.Text = "Asignación";
            this.btnAsigDisp.UseVisualStyleBackColor = false;
            this.btnAsigDisp.Click += new System.EventHandler(this.btnAsigDisp_Click);
            // 
            // btnAltaDisp
            // 
            this.btnAltaDisp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(90)))));
            this.btnAltaDisp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAltaDisp.FlatAppearance.BorderSize = 0;
            this.btnAltaDisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaDisp.Font = new System.Drawing.Font("Segoe UI Semilight", 9.8F);
            this.btnAltaDisp.ForeColor = System.Drawing.Color.White;
            this.btnAltaDisp.Image = ((System.Drawing.Image)(resources.GetObject("btnAltaDisp.Image")));
            this.btnAltaDisp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaDisp.Location = new System.Drawing.Point(0, 58);
            this.btnAltaDisp.Name = "btnAltaDisp";
            this.btnAltaDisp.Size = new System.Drawing.Size(210, 40);
            this.btnAltaDisp.TabIndex = 21;
            this.btnAltaDisp.Text = "Alta Dispositivo";
            this.btnAltaDisp.UseVisualStyleBackColor = false;
            this.btnAltaDisp.Click += new System.EventHandler(this.btnAltaDisp_Click);
            // 
            // btnDisp
            // 
            this.btnDisp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(90)))));
            this.btnDisp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDisp.FlatAppearance.BorderSize = 0;
            this.btnDisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisp.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisp.ForeColor = System.Drawing.Color.White;
            this.btnDisp.Image = ((System.Drawing.Image)(resources.GetObject("btnDisp.Image")));
            this.btnDisp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisp.Location = new System.Drawing.Point(0, 0);
            this.btnDisp.Name = "btnDisp";
            this.btnDisp.Size = new System.Drawing.Size(210, 58);
            this.btnDisp.TabIndex = 20;
            this.btnDisp.Text = "Dispositivos";
            this.btnDisp.UseVisualStyleBackColor = false;
            this.btnDisp.Click += new System.EventHandler(this.btnDisp_Click);
            this.btnDisp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDisp_MouseDown);
            this.btnDisp.MouseEnter += new System.EventHandler(this.btnDisp_MouseEnter);
            this.btnDisp.MouseLeave += new System.EventHandler(this.btnDisp_MouseLeave);
            this.btnDisp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDisp_MouseUp);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 58);
            this.button2.TabIndex = 8;
            this.button2.Text = "Clientes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "Escritorio";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelContenido
            // 
            this.panelContenido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelContenido.BackgroundImage")));
            this.panelContenido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(210, 28);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1052, 693);
            this.panelContenido.TabIndex = 2;
            this.panelContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenido_Paint);
            // 
            // InterfazPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1280, 768);
            this.Name = "InterfazPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterfazPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InterfazPrincipal_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.panelDisp.ResumeLayout(false);
            this.panelDisp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTanques;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnChoferes;
        private System.Windows.Forms.Button btnPipa;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PipasDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnAsignarChofer;
        private System.Windows.Forms.ToolStripMenuItem dispositivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaciónToolStripMenuItem;
        private System.Windows.Forms.Panel panelDisp;
        private System.Windows.Forms.Button btnDisp;
        private System.Windows.Forms.Button btnAltaDisp;
        private System.Windows.Forms.Button btnDesasigDisp;
        private System.Windows.Forms.Button btnAsigDisp;
        private System.Windows.Forms.Label dropDisp;
    }
}