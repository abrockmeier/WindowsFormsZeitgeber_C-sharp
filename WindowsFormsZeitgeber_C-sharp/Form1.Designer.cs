namespace WindowsFormsZeitgeber_C_sharp
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
			this.components = new System.ComponentModel.Container();
			this.LBL_Anzeige = new System.Windows.Forms.Label();
			this.BT_Start = new System.Windows.Forms.Button();
			this.BT_Stop = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// LBL_Anzeige
			// 
			this.LBL_Anzeige.AutoSize = true;
			this.LBL_Anzeige.Location = new System.Drawing.Point(139, 133);
			this.LBL_Anzeige.Name = "LBL_Anzeige";
			this.LBL_Anzeige.Size = new System.Drawing.Size(44, 17);
			this.LBL_Anzeige.TabIndex = 0;
			this.LBL_Anzeige.Text = "NULL";
			this.LBL_Anzeige.Click += new System.EventHandler(this.LBL_Anzeige_Click);
			// 
			// BT_Start
			// 
			this.BT_Start.Location = new System.Drawing.Point(125, 295);
			this.BT_Start.Name = "BT_Start";
			this.BT_Start.Size = new System.Drawing.Size(75, 23);
			this.BT_Start.TabIndex = 1;
			this.BT_Start.Text = "Start";
			this.BT_Start.UseVisualStyleBackColor = true;
			this.BT_Start.Click += new System.EventHandler(this.BT_Start_Click);
			// 
			// BT_Stop
			// 
			this.BT_Stop.Location = new System.Drawing.Point(398, 295);
			this.BT_Stop.Name = "BT_Stop";
			this.BT_Stop.Size = new System.Drawing.Size(75, 23);
			this.BT_Stop.TabIndex = 2;
			this.BT_Stop.Text = "Stop";
			this.BT_Stop.UseVisualStyleBackColor = true;
			this.BT_Stop.Click += new System.EventHandler(this.BT_Stop_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 500;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.BT_Stop);
			this.Controls.Add(this.BT_Start);
			this.Controls.Add(this.LBL_Anzeige);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LBL_Anzeige;
		private System.Windows.Forms.Button BT_Start;
		private System.Windows.Forms.Button BT_Stop;
		private System.Windows.Forms.Timer timer1;
	}
}

