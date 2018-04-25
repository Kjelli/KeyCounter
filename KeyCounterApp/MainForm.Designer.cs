using System;

namespace KeyCounterApp
{
	partial class MainForm
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			this.KeyCountChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.StartStopButton = new System.Windows.Forms.Button();
			this.ExportButton = new System.Windows.Forms.Button();
			this.SubtractHour = new System.Windows.Forms.Button();
			this.AddHour = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.ExportedLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.KeyCountChart)).BeginInit();
			this.SuspendLayout();
			// 
			// KeyCountChart
			// 
			chartArea1.AxisX.MajorGrid.LineWidth = 0;
			chartArea1.AxisY.MajorGrid.LineWidth = 0;
			chartArea1.Name = "ChartArea1";
			this.KeyCountChart.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.KeyCountChart.Legends.Add(legend1);
			this.KeyCountChart.Location = new System.Drawing.Point(12, 12);
			this.KeyCountChart.Name = "KeyCountChart";
			this.KeyCountChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
			this.KeyCountChart.Size = new System.Drawing.Size(758, 175);
			this.KeyCountChart.TabIndex = 3;
			this.KeyCountChart.Text = "Keycounts";
			// 
			// StartStopButton
			// 
			this.StartStopButton.BackColor = System.Drawing.Color.Green;
			this.StartStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.StartStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StartStopButton.ForeColor = System.Drawing.Color.White;
			this.StartStopButton.Location = new System.Drawing.Point(776, 11);
			this.StartStopButton.Name = "StartStopButton";
			this.StartStopButton.Size = new System.Drawing.Size(146, 40);
			this.StartStopButton.TabIndex = 4;
			this.StartStopButton.Text = "Start";
			this.StartStopButton.UseVisualStyleBackColor = false;
			this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
			// 
			// ExportButton
			// 
			this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ExportButton.Location = new System.Drawing.Point(776, 57);
			this.ExportButton.Name = "ExportButton";
			this.ExportButton.Size = new System.Drawing.Size(146, 40);
			this.ExportButton.TabIndex = 5;
			this.ExportButton.Text = "Export";
			this.ExportButton.UseVisualStyleBackColor = true;
			this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
			// 
			// SubtractHour
			// 
			this.SubtractHour.Location = new System.Drawing.Point(776, 103);
			this.SubtractHour.Name = "SubtractHour";
			this.SubtractHour.Size = new System.Drawing.Size(66, 23);
			this.SubtractHour.TabIndex = 8;
			this.SubtractHour.Text = "- Hour";
			this.SubtractHour.UseVisualStyleBackColor = true;
			this.SubtractHour.Click += new System.EventHandler(this.SubtractHour_Click);
			// 
			// AddHour
			// 
			this.AddHour.Location = new System.Drawing.Point(854, 103);
			this.AddHour.Name = "AddHour";
			this.AddHour.Size = new System.Drawing.Size(66, 23);
			this.AddHour.TabIndex = 9;
			this.AddHour.Text = "+ Hour";
			this.AddHour.UseVisualStyleBackColor = true;
			this.AddHour.Click += new System.EventHandler(this.AddHour_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ExitButton.Location = new System.Drawing.Point(776, 164);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(146, 40);
			this.ExitButton.TabIndex = 10;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// ExportedLabel
			// 
			this.ExportedLabel.AutoSize = true;
			this.ExportedLabel.Location = new System.Drawing.Point(9, 195);
			this.ExportedLabel.Name = "ExportedLabel";
			this.ExportedLabel.Size = new System.Drawing.Size(16, 13);
			this.ExportedLabel.TabIndex = 11;
			this.ExportedLabel.Text = "...";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(934, 217);
			this.Controls.Add(this.ExportedLabel);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.AddHour);
			this.Controls.Add(this.SubtractHour);
			this.Controls.Add(this.ExportButton);
			this.Controls.Add(this.StartStopButton);
			this.Controls.Add(this.KeyCountChart);
			this.Name = "MainForm";
			this.Text = "CapScience Keycounter™";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.KeyCountChart)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

#endregion
		private System.Windows.Forms.DataVisualization.Charting.Chart KeyCountChart;
		private System.Windows.Forms.Button StartStopButton;
		private System.Windows.Forms.Button ExportButton;
		private System.Windows.Forms.Button SubtractHour;
		private System.Windows.Forms.Button AddHour;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Label ExportedLabel;
	}
}

