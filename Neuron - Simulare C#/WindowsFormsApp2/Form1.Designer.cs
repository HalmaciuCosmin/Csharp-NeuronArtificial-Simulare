namespace WindowsFormsApp2
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
            this.NumarConexiuni = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.GID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Suma_R = new System.Windows.Forms.RadioButton();
            this.Produs_R = new System.Windows.Forms.RadioButton();
            this.Min_R = new System.Windows.Forms.RadioButton();
            this.Max_R = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Functia = new System.Windows.Forms.ComboBox();
            this.Rezultat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GsiA_Label = new System.Windows.Forms.Label();
            this.prag_label = new System.Windows.Forms.Label();
            this.GsiA_Value = new System.Windows.Forms.NumericUpDown();
            this.prag_Value = new System.Windows.Forms.NumericUpDown();
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.RezultatFinal = new System.Windows.Forms.TextBox();
            this.Binar = new System.Windows.Forms.CheckBox();
            this.Activare = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumarConexiuni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GsiA_Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prag_Value)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumarConexiuni
            // 
            this.NumarConexiuni.Location = new System.Drawing.Point(136, 12);
            this.NumarConexiuni.Name = "NumarConexiuni";
            this.NumarConexiuni.Size = new System.Drawing.Size(81, 20);
            this.NumarConexiuni.TabIndex = 1;
            this.NumarConexiuni.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumarConexiuni.ValueChanged += new System.EventHandler(this.NumarConexiuni_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numar Legaturi";
            // 
            // GID
            // 
            this.GID.CausesValidation = false;
            this.GID.Location = new System.Drawing.Point(251, 65);
            this.GID.Name = "GID";
            this.GID.ReadOnly = true;
            this.GID.Size = new System.Drawing.Size(100, 20);
            this.GID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Global Input";
            // 
            // Suma_R
            // 
            this.Suma_R.AutoSize = true;
            this.Suma_R.Location = new System.Drawing.Point(265, 126);
            this.Suma_R.Name = "Suma_R";
            this.Suma_R.Size = new System.Drawing.Size(52, 17);
            this.Suma_R.TabIndex = 5;
            this.Suma_R.TabStop = true;
            this.Suma_R.Text = "Suma";
            this.Suma_R.UseVisualStyleBackColor = true;
            // 
            // Produs_R
            // 
            this.Produs_R.AutoSize = true;
            this.Produs_R.Location = new System.Drawing.Point(265, 159);
            this.Produs_R.Name = "Produs_R";
            this.Produs_R.Size = new System.Drawing.Size(58, 17);
            this.Produs_R.TabIndex = 6;
            this.Produs_R.TabStop = true;
            this.Produs_R.Text = "Produs";
            this.Produs_R.UseVisualStyleBackColor = true;
            // 
            // Min_R
            // 
            this.Min_R.AutoSize = true;
            this.Min_R.Location = new System.Drawing.Point(265, 192);
            this.Min_R.Name = "Min_R";
            this.Min_R.Size = new System.Drawing.Size(42, 17);
            this.Min_R.TabIndex = 7;
            this.Min_R.TabStop = true;
            this.Min_R.Text = "Min";
            this.Min_R.UseVisualStyleBackColor = true;
            // 
            // Max_R
            // 
            this.Max_R.AutoSize = true;
            this.Max_R.Location = new System.Drawing.Point(265, 226);
            this.Max_R.Name = "Max_R";
            this.Max_R.Size = new System.Drawing.Size(45, 17);
            this.Max_R.TabIndex = 8;
            this.Max_R.TabStop = true;
            this.Max_R.Text = "Max";
            this.Max_R.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Functia";
            // 
            // Functia
            // 
            this.Functia.FormattingEnabled = true;
            this.Functia.Location = new System.Drawing.Point(405, 126);
            this.Functia.Name = "Functia";
            this.Functia.Size = new System.Drawing.Size(111, 21);
            this.Functia.TabIndex = 10;
            // 
            // Rezultat
            // 
            this.Rezultat.CausesValidation = false;
            this.Rezultat.Location = new System.Drawing.Point(405, 65);
            this.Rezultat.Name = "Rezultat";
            this.Rezultat.ReadOnly = true;
            this.Rezultat.Size = new System.Drawing.Size(111, 20);
            this.Rezultat.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Rezultat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Functia";
            // 
            // GsiA_Label
            // 
            this.GsiA_Label.AutoSize = true;
            this.GsiA_Label.Location = new System.Drawing.Point(402, 174);
            this.GsiA_Label.Name = "GsiA_Label";
            this.GsiA_Label.Size = new System.Drawing.Size(13, 13);
            this.GsiA_Label.TabIndex = 14;
            this.GsiA_Label.Text = "g";
            // 
            // prag_label
            // 
            this.prag_label.AutoSize = true;
            this.prag_label.Location = new System.Drawing.Point(402, 215);
            this.prag_label.Name = "prag_label";
            this.prag_label.Size = new System.Drawing.Size(28, 13);
            this.prag_label.TabIndex = 15;
            this.prag_label.Text = "prag";
            // 
            // GsiA_Value
            // 
            this.GsiA_Value.DecimalPlaces = 2;
            this.GsiA_Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.GsiA_Value.Location = new System.Drawing.Point(435, 172);
            this.GsiA_Value.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.GsiA_Value.Name = "GsiA_Value";
            this.GsiA_Value.Size = new System.Drawing.Size(52, 20);
            this.GsiA_Value.TabIndex = 16;
            this.GsiA_Value.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // prag_Value
            // 
            this.prag_Value.DecimalPlaces = 2;
            this.prag_Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.prag_Value.Location = new System.Drawing.Point(436, 213);
            this.prag_Value.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.prag_Value.Name = "prag_Value";
            this.prag_Value.Size = new System.Drawing.Size(51, 20);
            this.prag_Value.TabIndex = 17;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(0, 6);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(205, 243);
            this.panel.TabIndex = 0;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.panel);
            this.groupBox.Location = new System.Drawing.Point(15, 38);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(205, 249);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // RezultatFinal
            // 
            this.RezultatFinal.CausesValidation = false;
            this.RezultatFinal.Location = new System.Drawing.Point(541, 65);
            this.RezultatFinal.Name = "RezultatFinal";
            this.RezultatFinal.ReadOnly = true;
            this.RezultatFinal.Size = new System.Drawing.Size(111, 20);
            this.RezultatFinal.TabIndex = 19;
            // 
            // Binar
            // 
            this.Binar.AutoSize = true;
            this.Binar.Location = new System.Drawing.Point(541, 170);
            this.Binar.Name = "Binar";
            this.Binar.Size = new System.Drawing.Size(50, 17);
            this.Binar.TabIndex = 20;
            this.Binar.Text = "Binar";
            this.Binar.UseVisualStyleBackColor = true;
            // 
            // Activare
            // 
            this.Activare.CausesValidation = false;
            this.Activare.Location = new System.Drawing.Point(541, 125);
            this.Activare.Name = "Activare";
            this.Activare.ReadOnly = true;
            this.Activare.Size = new System.Drawing.Size(111, 20);
            this.Activare.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(562, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Rezultat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 311);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Activare);
            this.Controls.Add(this.Binar);
            this.Controls.Add(this.RezultatFinal);
            this.Controls.Add(this.prag_Value);
            this.Controls.Add(this.GsiA_Value);
            this.Controls.Add(this.prag_label);
            this.Controls.Add(this.GsiA_Label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Rezultat);
            this.Controls.Add(this.Functia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Max_R);
            this.Controls.Add(this.Min_R);
            this.Controls.Add(this.Produs_R);
            this.Controls.Add(this.Suma_R);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumarConexiuni);
            this.Controls.Add(this.groupBox);
            this.Name = "Form1";
            this.Text = "Neuron";
            ((System.ComponentModel.ISupportInitialize)(this.NumarConexiuni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GsiA_Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prag_Value)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown NumarConexiuni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Suma_R;
        private System.Windows.Forms.RadioButton Produs_R;
        private System.Windows.Forms.RadioButton Min_R;
        private System.Windows.Forms.RadioButton Max_R;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Functia;
        private System.Windows.Forms.TextBox Rezultat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label GsiA_Label;
        private System.Windows.Forms.Label prag_label;
        private System.Windows.Forms.NumericUpDown GsiA_Value;
        private System.Windows.Forms.NumericUpDown prag_Value;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox RezultatFinal;
        private System.Windows.Forms.CheckBox Binar;
        private System.Windows.Forms.TextBox Activare;
        private System.Windows.Forms.Label label8;
    }
}

