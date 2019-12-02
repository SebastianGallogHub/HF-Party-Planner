namespace Party_Planner
{
    partial class Planner
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.FancyDecorations = new System.Windows.Forms.CheckBox();
            this.HealthyOption = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of People:";
            // 
            // FancyDecorations
            // 
            this.FancyDecorations.AutoSize = true;
            this.FancyDecorations.Checked = true;
            this.FancyDecorations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FancyDecorations.Location = new System.Drawing.Point(29, 70);
            this.FancyDecorations.Name = "FancyDecorations";
            this.FancyDecorations.Size = new System.Drawing.Size(115, 17);
            this.FancyDecorations.TabIndex = 2;
            this.FancyDecorations.Text = "Fancy Decorations";
            this.FancyDecorations.UseVisualStyleBackColor = true;
            this.FancyDecorations.CheckedChanged += new System.EventHandler(this.FancyDecorations_CheckedChanged);
            // 
            // HealthyOption
            // 
            this.HealthyOption.AutoSize = true;
            this.HealthyOption.Location = new System.Drawing.Point(29, 93);
            this.HealthyOption.Name = "HealthyOption";
            this.HealthyOption.Size = new System.Drawing.Size(96, 17);
            this.HealthyOption.TabIndex = 2;
            this.HealthyOption.Text = "Healthy Option";
            this.HealthyOption.UseVisualStyleBackColor = true;
            this.HealthyOption.CheckedChanged += new System.EventHandler(this.HealthyOption_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cost:";
            // 
            // Cost
            // 
            this.Cost.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost.Location = new System.Drawing.Point(70, 119);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(75, 23);
            this.Cost.TabIndex = 0;
            this.Cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(32, 38);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(109, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Planner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 160);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.HealthyOption);
            this.Controls.Add(this.FancyDecorations);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Planner";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox FancyDecorations;
        private System.Windows.Forms.CheckBox HealthyOption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

