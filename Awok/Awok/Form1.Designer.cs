namespace Awok
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panelLinks = new System.Windows.Forms.Panel();
			this.abfrageB = new System.Windows.Forms.Button();
			this.eingabe = new System.Windows.Forms.Button();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.Logo = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.benutzerB = new System.Windows.Forms.Button();
			this.PanelOben = new System.Windows.Forms.Panel();
			this.mini = new System.Windows.Forms.Label();
			this.X = new System.Windows.Forms.Label();
			this.MenuText = new System.Windows.Forms.Label();
			this.Inhalt = new System.Windows.Forms.Panel();
			this.benutzer1 = new Awok.Benutzer();
			this.eingabe1 = new Awok.Eingabe();
			this.panelLinks.SuspendLayout();
			this.panelLogo.SuspendLayout();
			this.panel1.SuspendLayout();
			this.PanelOben.SuspendLayout();
			this.Inhalt.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelLinks
			// 
			this.panelLinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panelLinks.Controls.Add(this.abfrageB);
			this.panelLinks.Controls.Add(this.eingabe);
			this.panelLinks.Controls.Add(this.panelLogo);
			this.panelLinks.Controls.Add(this.panel1);
			this.panelLinks.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelLinks.Location = new System.Drawing.Point(0, 0);
			this.panelLinks.Name = "panelLinks";
			this.panelLinks.Size = new System.Drawing.Size(200, 478);
			this.panelLinks.TabIndex = 0;
			this.panelLinks.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLinks_Paint);
			this.panelLinks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			// 
			// abfrageB
			// 
			this.abfrageB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.abfrageB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.abfrageB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.abfrageB.ForeColor = System.Drawing.Color.Gray;
			this.abfrageB.Location = new System.Drawing.Point(-10, 110);
			this.abfrageB.Name = "abfrageB";
			this.abfrageB.Size = new System.Drawing.Size(219, 46);
			this.abfrageB.TabIndex = 2;
			this.abfrageB.Text = "Abfrage";
			this.abfrageB.UseVisualStyleBackColor = false;
			this.abfrageB.Click += new System.EventHandler(this.AbfrageB_Click);
			// 
			// eingabe
			// 
			this.eingabe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.eingabe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.eingabe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.eingabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.eingabe.ForeColor = System.Drawing.Color.Gray;
			this.eingabe.Location = new System.Drawing.Point(-10, 61);
			this.eingabe.Name = "eingabe";
			this.eingabe.Size = new System.Drawing.Size(219, 46);
			this.eingabe.TabIndex = 1;
			this.eingabe.Text = "Eingabe";
			this.eingabe.UseVisualStyleBackColor = false;
			this.eingabe.Click += new System.EventHandler(this.Button1_Click);
			// 
			// panelLogo
			// 
			this.panelLogo.BackColor = System.Drawing.Color.LightCoral;
			this.panelLogo.Controls.Add(this.Logo);
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLogo.Location = new System.Drawing.Point(0, 0);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Size = new System.Drawing.Size(200, 55);
			this.panelLogo.TabIndex = 0;
			this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLogo_Paint);
			// 
			// Logo
			// 
			this.Logo.Font = new System.Drawing.Font("Nasalization", 22F);
			this.Logo.ForeColor = System.Drawing.SystemColors.Control;
			this.Logo.Location = new System.Drawing.Point(0, 0);
			this.Logo.Name = "Logo";
			this.Logo.Size = new System.Drawing.Size(200, 55);
			this.Logo.TabIndex = 0;
			this.Logo.Text = "Awok";
			this.Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Logo.Click += new System.EventHandler(this.Label1_Click);
			this.Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.benutzerB);
			this.panel1.Location = new System.Drawing.Point(-10, 378);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(219, 100);
			this.panel1.TabIndex = 4;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Gray;
			this.button1.Location = new System.Drawing.Point(3, 51);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(219, 46);
			this.button1.TabIndex = 4;
			this.button1.Text = "Optionen";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1_Click_1);
			// 
			// benutzerB
			// 
			this.benutzerB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.benutzerB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.benutzerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.benutzerB.ForeColor = System.Drawing.Color.Gray;
			this.benutzerB.Location = new System.Drawing.Point(3, 3);
			this.benutzerB.Name = "benutzerB";
			this.benutzerB.Size = new System.Drawing.Size(219, 46);
			this.benutzerB.TabIndex = 3;
			this.benutzerB.Text = "Benutzer";
			this.benutzerB.UseVisualStyleBackColor = false;
			this.benutzerB.Click += new System.EventHandler(this.BenutzerB_Click);
			this.benutzerB.Enter += new System.EventHandler(this.BenutzerB_Click);
			// 
			// PanelOben
			// 
			this.PanelOben.BackColor = System.Drawing.Color.White;
			this.PanelOben.Controls.Add(this.mini);
			this.PanelOben.Controls.Add(this.X);
			this.PanelOben.Controls.Add(this.MenuText);
			this.PanelOben.Dock = System.Windows.Forms.DockStyle.Top;
			this.PanelOben.Location = new System.Drawing.Point(200, 0);
			this.PanelOben.Name = "PanelOben";
			this.PanelOben.Size = new System.Drawing.Size(620, 55);
			this.PanelOben.TabIndex = 1;
			this.PanelOben.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelOben_Paint);
			this.PanelOben.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			// 
			// mini
			// 
			this.mini.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mini.Cursor = System.Windows.Forms.Cursors.Hand;
			this.mini.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
			this.mini.ForeColor = System.Drawing.Color.Gray;
			this.mini.Location = new System.Drawing.Point(560, 9);
			this.mini.Name = "mini";
			this.mini.Size = new System.Drawing.Size(18, 33);
			this.mini.TabIndex = 2;
			this.mini.Text = "-";
			this.mini.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mini.Click += new System.EventHandler(this.Mini_Click);
			// 
			// X
			// 
			this.X.Cursor = System.Windows.Forms.Cursors.Hand;
			this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
			this.X.ForeColor = System.Drawing.Color.Gray;
			this.X.Location = new System.Drawing.Point(584, 15);
			this.X.Name = "X";
			this.X.Size = new System.Drawing.Size(24, 27);
			this.X.TabIndex = 1;
			this.X.Text = "X";
			this.X.Click += new System.EventHandler(this.X_Click);
			// 
			// MenuText
			// 
			this.MenuText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
			this.MenuText.ForeColor = System.Drawing.Color.Gray;
			this.MenuText.Location = new System.Drawing.Point(46, 15);
			this.MenuText.Name = "MenuText";
			this.MenuText.Size = new System.Drawing.Size(102, 27);
			this.MenuText.TabIndex = 0;
			this.MenuText.Text = "Benutzer";
			this.MenuText.Click += new System.EventHandler(this.MenuText_Click);
			// 
			// Inhalt
			// 
			this.Inhalt.Controls.Add(this.eingabe1);
			this.Inhalt.Controls.Add(this.benutzer1);
			this.Inhalt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Inhalt.Location = new System.Drawing.Point(200, 55);
			this.Inhalt.Name = "Inhalt";
			this.Inhalt.Size = new System.Drawing.Size(620, 423);
			this.Inhalt.TabIndex = 2;
			this.Inhalt.Paint += new System.Windows.Forms.PaintEventHandler(this.Inhalt_Paint);
			// 
			// benutzer1
			// 
			this.benutzer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.benutzer1.Location = new System.Drawing.Point(0, 0);
			this.benutzer1.Name = "benutzer1";
			this.benutzer1.Size = new System.Drawing.Size(620, 423);
			this.benutzer1.TabIndex = 0;
			this.benutzer1.Visible = false;
			this.benutzer1.Load += new System.EventHandler(this.Benutzer1_Load);
			// 
			// eingabe1
			// 
			this.eingabe1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.eingabe1.Location = new System.Drawing.Point(0, 0);
			this.eingabe1.Name = "eingabe1";
			this.eingabe1.Size = new System.Drawing.Size(620, 423);
			this.eingabe1.TabIndex = 1;
			this.eingabe1.Visible = false;
			this.eingabe1.Load += new System.EventHandler(this.Eingabe1_Load);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(820, 478);
			this.Controls.Add(this.Inhalt);
			this.Controls.Add(this.PanelOben);
			this.Controls.Add(this.panelLinks);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Awok";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.panelLinks.ResumeLayout(false);
			this.panelLogo.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.PanelOben.ResumeLayout(false);
			this.Inhalt.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelLinks;
		private System.Windows.Forms.Button eingabe;
		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.Label Logo;
		private System.Windows.Forms.Panel PanelOben;
		private System.Windows.Forms.Button abfrageB;
		private System.Windows.Forms.Label MenuText;
		private System.Windows.Forms.Label X;
		private System.Windows.Forms.Label mini;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button benutzerB;
		private System.Windows.Forms.Panel Inhalt;
		private Benutzer benutzer1;
		private Eingabe eingabe1;
	}
}

