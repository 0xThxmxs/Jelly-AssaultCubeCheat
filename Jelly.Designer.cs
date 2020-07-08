namespace Jelly
{
    partial class Jelly
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jelly));
            this.valuesetter = new System.Windows.Forms.GroupBox();
            this.valueSetterOffsetsListBox = new System.Windows.Forms.ListBox();
            this.loopValueSetterCheckbox = new System.Windows.Forms.CheckBox();
            this.valueSetterNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.setValueButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ghostModeCheckbox = new System.Windows.Forms.CheckBox();
            this.flyCheckbox = new System.Windows.Forms.CheckBox();
            this.godModeCheckbox = new System.Windows.Forms.CheckBox();
            this.valuesetter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueSetterNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // valuesetter
            // 
            this.valuesetter.Controls.Add(this.valueSetterOffsetsListBox);
            this.valuesetter.Controls.Add(this.loopValueSetterCheckbox);
            this.valuesetter.Controls.Add(this.valueSetterNumericUpDown);
            this.valuesetter.Controls.Add(this.setValueButton);
            this.valuesetter.ForeColor = System.Drawing.Color.White;
            this.valuesetter.Location = new System.Drawing.Point(12, 12);
            this.valuesetter.Name = "valuesetter";
            this.valuesetter.Size = new System.Drawing.Size(440, 132);
            this.valuesetter.TabIndex = 8;
            this.valuesetter.TabStop = false;
            this.valuesetter.Text = "Value setter";
            // 
            // valueSetterOffsetsListBox
            // 
            this.valueSetterOffsetsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.valueSetterOffsetsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valueSetterOffsetsListBox.ForeColor = System.Drawing.Color.White;
            this.valueSetterOffsetsListBox.FormattingEnabled = true;
            this.valueSetterOffsetsListBox.Items.AddRange(new object[] {
            "armorAmmount",
            "assaultRifleAmmo",
            "assaultRifleExtraAmmoMagazine",
            "grenadeNumber",
            "healthPoints",
            "playerVelocity",
            "semiAutomaticPistolAmmo",
            "semiAutomaticPistolExtraAmmoMagazine"});
            this.valueSetterOffsetsListBox.Location = new System.Drawing.Point(9, 19);
            this.valueSetterOffsetsListBox.Name = "valueSetterOffsetsListBox";
            this.valueSetterOffsetsListBox.Size = new System.Drawing.Size(242, 106);
            this.valueSetterOffsetsListBox.TabIndex = 9;
            // 
            // loopValueSetterCheckbox
            // 
            this.loopValueSetterCheckbox.AutoSize = true;
            this.loopValueSetterCheckbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.loopValueSetterCheckbox.ForeColor = System.Drawing.Color.White;
            this.loopValueSetterCheckbox.Location = new System.Drawing.Point(257, 19);
            this.loopValueSetterCheckbox.Name = "loopValueSetterCheckbox";
            this.loopValueSetterCheckbox.Size = new System.Drawing.Size(50, 17);
            this.loopValueSetterCheckbox.TabIndex = 6;
            this.loopValueSetterCheckbox.Text = "Loop";
            this.loopValueSetterCheckbox.UseVisualStyleBackColor = true;
            this.loopValueSetterCheckbox.CheckedChanged += new System.EventHandler(this.ValueSetterLoopCheckboxEvent);
            // 
            // valueSetterNumericUpDown
            // 
            this.valueSetterNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.valueSetterNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valueSetterNumericUpDown.ForeColor = System.Drawing.Color.White;
            this.valueSetterNumericUpDown.Location = new System.Drawing.Point(313, 19);
            this.valueSetterNumericUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.valueSetterNumericUpDown.Name = "valueSetterNumericUpDown";
            this.valueSetterNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.valueSetterNumericUpDown.TabIndex = 5;
            // 
            // setValueButton
            // 
            this.setValueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.setValueButton.ForeColor = System.Drawing.Color.White;
            this.setValueButton.Location = new System.Drawing.Point(257, 45);
            this.setValueButton.Name = "setValueButton";
            this.setValueButton.Size = new System.Drawing.Size(177, 80);
            this.setValueButton.TabIndex = 0;
            this.setValueButton.Text = "Set value";
            this.setValueButton.UseVisualStyleBackColor = false;
            this.setValueButton.Click += new System.EventHandler(this.ValueSetterButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(6, 16);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(0, 13);
            this.logLabel.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.logLabel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 99);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logs";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ghostModeCheckbox);
            this.groupBox1.Controls.Add(this.flyCheckbox);
            this.groupBox1.Controls.Add(this.godModeCheckbox);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(354, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 99);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Global hacks";
            // 
            // ghostModeCheckbox
            // 
            this.ghostModeCheckbox.AutoSize = true;
            this.ghostModeCheckbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ghostModeCheckbox.ForeColor = System.Drawing.Color.White;
            this.ghostModeCheckbox.Location = new System.Drawing.Point(6, 42);
            this.ghostModeCheckbox.Name = "ghostModeCheckbox";
            this.ghostModeCheckbox.Size = new System.Drawing.Size(84, 17);
            this.ghostModeCheckbox.TabIndex = 10;
            this.ghostModeCheckbox.Text = "Ghost Mode";
            this.ghostModeCheckbox.UseVisualStyleBackColor = true;
            this.ghostModeCheckbox.CheckedChanged += new System.EventHandler(this.IsGlobalHacksGhostModCheckboxEnabled);
            // 
            // flyCheckbox
            // 
            this.flyCheckbox.AutoSize = true;
            this.flyCheckbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.flyCheckbox.ForeColor = System.Drawing.Color.White;
            this.flyCheckbox.Location = new System.Drawing.Point(6, 19);
            this.flyCheckbox.Name = "flyCheckbox";
            this.flyCheckbox.Size = new System.Drawing.Size(39, 17);
            this.flyCheckbox.TabIndex = 8;
            this.flyCheckbox.Text = "Fly";
            this.flyCheckbox.UseVisualStyleBackColor = true;
            this.flyCheckbox.CheckedChanged += new System.EventHandler(this.IsGlobalHacksFlyCheckboxEnabled);
            // 
            // godModeCheckbox
            // 
            this.godModeCheckbox.AutoSize = true;
            this.godModeCheckbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.godModeCheckbox.ForeColor = System.Drawing.Color.White;
            this.godModeCheckbox.Location = new System.Drawing.Point(6, 65);
            this.godModeCheckbox.Name = "godModeCheckbox";
            this.godModeCheckbox.Size = new System.Drawing.Size(70, 17);
            this.godModeCheckbox.TabIndex = 7;
            this.godModeCheckbox.Text = "God Mod";
            this.godModeCheckbox.UseVisualStyleBackColor = true;
            this.godModeCheckbox.CheckedChanged += new System.EventHandler(this.IsGlobalHacksGodModCheckboxEnabled);
            // 
            // Jelly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(464, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.valuesetter);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 300);
            this.Name = "Jelly";
            this.Text = "Jelly by 0xThxmxs";
            this.Load += new System.EventHandler(this.Jelly_Load);
            this.valuesetter.ResumeLayout(false);
            this.valuesetter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueSetterNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.GroupBox valuesetter;
        private System.Windows.Forms.CheckBox loopValueSetterCheckbox;
        private System.Windows.Forms.NumericUpDown valueSetterNumericUpDown;
        private System.Windows.Forms.Button setValueButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox valueSetterOffsetsListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox godModeCheckbox;
        private System.Windows.Forms.CheckBox flyCheckbox;
        private System.Windows.Forms.CheckBox ghostModeCheckbox;
    }
}

