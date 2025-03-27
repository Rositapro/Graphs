namespace Graph
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fmpEngine = new ScottPlot.WinForms.FormsPlot();
            fmpAspiration = new ScottPlot.WinForms.FormsPlot();
            fmpNumofDoors = new ScottPlot.WinForms.FormsPlot();
            fmpNormalizedLosses = new ScottPlot.WinForms.FormsPlot();
            fmp1FuelType = new ScottPlot.WinForms.FormsPlot();
            dtgvAutomovile = new DataGridView();
            btnFilter = new Button();
            cmbFilter = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvAutomovile).BeginInit();
            SuspendLayout();
            // 
            // fmpEngine
            // 
            fmpEngine.DisplayScale = 1F;
            fmpEngine.Location = new Point(908, 330);
            fmpEngine.Name = "fmpEngine";
            fmpEngine.Size = new Size(218, 204);
            fmpEngine.TabIndex = 0;
            // 
            // fmpAspiration
            // 
            fmpAspiration.DisplayScale = 1F;
            fmpAspiration.Location = new Point(460, 330);
            fmpAspiration.Name = "fmpAspiration";
            fmpAspiration.Size = new Size(218, 204);
            fmpAspiration.TabIndex = 1;
            // 
            // fmpNumofDoors
            // 
            fmpNumofDoors.DisplayScale = 1F;
            fmpNumofDoors.Location = new Point(684, 330);
            fmpNumofDoors.Name = "fmpNumofDoors";
            fmpNumofDoors.Size = new Size(218, 204);
            fmpNumofDoors.TabIndex = 2;
            // 
            // fmpNormalizedLosses
            // 
            fmpNormalizedLosses.DisplayScale = 1F;
            fmpNormalizedLosses.Location = new Point(236, 330);
            fmpNormalizedLosses.Name = "fmpNormalizedLosses";
            fmpNormalizedLosses.Size = new Size(218, 204);
            fmpNormalizedLosses.TabIndex = 3;
            // 
            // fmp1FuelType
            // 
            fmp1FuelType.DisplayScale = 1F;
            fmp1FuelType.Location = new Point(12, 330);
            fmp1FuelType.Name = "fmp1FuelType";
            fmp1FuelType.Size = new Size(218, 204);
            fmp1FuelType.TabIndex = 4;
            // 
            // dtgvAutomovile
            // 
            dtgvAutomovile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAutomovile.Location = new Point(236, 32);
            dtgvAutomovile.Name = "dtgvAutomovile";
            dtgvAutomovile.Size = new Size(654, 262);
            dtgvAutomovile.TabIndex = 5;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(155, 32);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 7;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "Toyota", "Nissan", "Mazda", "Mitsubishi", "Honda", "Volkswagen", "Subaru", "Peugot", "Volvo", "Dodge", "Mercedes-Benz", "BMW", "Audi", "Plymouth", "Saab", "Porsche", "Isuzu", "Jaguar", "Chevrolet", "Alfa Romeo", "Renault", "Mercury" });
            cmbFilter.Location = new Point(25, 32);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(121, 23);
            cmbFilter.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 312);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 10;
            label2.Text = "Fuel type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 312);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 10;
            label3.Text = "Fuel type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(312, 312);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 11;
            label1.Text = "Normalized losses";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(546, 312);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 12;
            label4.Text = "Aspiration";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(990, 312);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 13;
            label5.Text = "Engine localitation";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(758, 312);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 14;
            label6.Text = "num of doors";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 537);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbFilter);
            Controls.Add(btnFilter);
            Controls.Add(dtgvAutomovile);
            Controls.Add(fmp1FuelType);
            Controls.Add(fmpNormalizedLosses);
            Controls.Add(fmpNumofDoors);
            Controls.Add(fmpAspiration);
            Controls.Add(fmpEngine);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgvAutomovile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot fmpEngine;
        private ScottPlot.WinForms.FormsPlot fmpAspiration;
        private ScottPlot.WinForms.FormsPlot fmpNumofDoors;
        private ScottPlot.WinForms.FormsPlot fmpNormalizedLosses;
        private ScottPlot.WinForms.FormsPlot fmp1FuelType;
        private DataGridView dtgvAutomovile;
        private Button btnFilter;
        private ComboBox cmbFilter;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
