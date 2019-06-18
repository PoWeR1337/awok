namespace Awok
{
	partial class Eingabe
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

		#region Vom Komponenten-Designer generierter Code

		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.zweite = new System.Windows.Forms.Label();
			this.erste = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ersteText = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.zweiteText = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.zweite, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.erste, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(620, 420);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// zweite
			// 
			this.zweite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.zweite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.zweite.ForeColor = System.Drawing.Color.Gray;
			this.zweite.Location = new System.Drawing.Point(313, 0);
			this.zweite.Name = "zweite";
			this.zweite.Size = new System.Drawing.Size(304, 63);
			this.zweite.TabIndex = 4;
			this.zweite.Text = "Antwort eingeben";
			this.zweite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// erste
			// 
			this.erste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.erste.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.erste.ForeColor = System.Drawing.Color.Gray;
			this.erste.Location = new System.Drawing.Point(3, 0);
			this.erste.Name = "erste";
			this.erste.Size = new System.Drawing.Size(304, 63);
			this.erste.TabIndex = 3;
			this.erste.Text = "Frage eingeben";
			this.erste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.Controls.Add(this.ersteText);
			this.panel1.Location = new System.Drawing.Point(50, 112);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(210, 259);
			this.panel1.TabIndex = 0;
			// 
			// ersteText
			// 
			this.ersteText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ersteText.Location = new System.Drawing.Point(0, 0);
			this.ersteText.Multiline = true;
			this.ersteText.Name = "ersteText";
			this.ersteText.Size = new System.Drawing.Size(210, 259);
			this.ersteText.TabIndex = 0;
			this.ersteText.TextChanged += new System.EventHandler(this.ErsteText_TextChanged);
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel2.Controls.Add(this.zweiteText);
			this.panel2.Location = new System.Drawing.Point(360, 112);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(210, 259);
			this.panel2.TabIndex = 1;
			// 
			// zweiteText
			// 
			this.zweiteText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.zweiteText.Location = new System.Drawing.Point(0, 0);
			this.zweiteText.Multiline = true;
			this.zweiteText.Name = "zweiteText";
			this.zweiteText.Size = new System.Drawing.Size(210, 259);
			this.zweiteText.TabIndex = 0;
			this.zweiteText.TextChanged += new System.EventHandler(this.ZweiteText_TextChanged);
			// 
			// Eingabe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Eingabe";
			this.Size = new System.Drawing.Size(620, 420);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label zweite;
		private System.Windows.Forms.Label erste;
		private System.Windows.Forms.TextBox ersteText;
		private System.Windows.Forms.TextBox zweiteText;
	}
}
