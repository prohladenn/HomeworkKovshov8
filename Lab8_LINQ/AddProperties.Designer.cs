namespace Lab8_LINQ
{
    partial class AddProperties
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

        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox surnameTxtBox;
        private System.Windows.Forms.TextBox brandIdTxtBox;
        private System.Windows.Forms.TextBox brandTxtBox;
        private System.Windows.Forms.TextBox gasolineTxtBox;
        private System.Windows.Forms.TextBox enginePowerTxtBox;
        private System.Windows.Forms.TextBox volumeTankTxtBox;
        private System.Windows.Forms.TextBox remainingGasTxtBox;
        private System.Windows.Forms.TextBox volumeOilTxtBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label brandIdLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label gasolineLabel;
        private System.Windows.Forms.Label enginePowerLabel;
        private System.Windows.Forms.Label volumeTankLabel;
        private System.Windows.Forms.Label remainingGasLabel;
        private System.Windows.Forms.Label volumeOilLabel;
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.surnameTxtBox = new System.Windows.Forms.TextBox();
            this.brandIdTxtBox = new System.Windows.Forms.TextBox();
            this.brandTxtBox = new System.Windows.Forms.TextBox();
            this.gasolineTxtBox = new System.Windows.Forms.TextBox();
            this.enginePowerTxtBox = new System.Windows.Forms.TextBox();
            this.volumeTankTxtBox = new System.Windows.Forms.TextBox();
            this.remainingGasTxtBox = new System.Windows.Forms.TextBox();
            this.volumeOilTxtBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.brandIdLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.gasolineLabel = new System.Windows.Forms.Label();
            this.enginePowerLabel = new System.Windows.Forms.Label();
            this.volumeTankLabel = new System.Windows.Forms.Label();
            this.remainingGasLabel = new System.Windows.Forms.Label();
            this.volumeOilLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Width = 150;
            this.surnameLabel.Location = new System.Drawing.Point(20, 10);
            this.surnameLabel.Text = "Фамилия: ";
 
            this.surnameTxtBox.Location = new System.Drawing.Point(20, 35);
            this.surnameTxtBox.Name = "surnameTxtBox";
            this.surnameTxtBox.Size = new System.Drawing.Size(350, 22);
            this.surnameTxtBox.TabIndex = 0;

            this.brandIdLabel.Name = "brandIdLabel";
            this.brandIdLabel.Width = 150;
            this.brandIdLabel.Location = new System.Drawing.Point(20, 60);
            this.brandIdLabel.Text = "Код марки: ";

            this.brandIdTxtBox.Location = new System.Drawing.Point(20, 85);
            this.brandIdTxtBox.Name = "brandIdTxtBox";
            this.brandIdTxtBox.Size = new System.Drawing.Size(350, 22);
            this.brandIdTxtBox.TabIndex = 1;

            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Width = 150;
            this.brandLabel.Location = new System.Drawing.Point(20, 110);
            this.brandLabel.Text = "Марка автомобиля: ";

            this.brandTxtBox.Location = new System.Drawing.Point(20, 135);
            this.brandTxtBox.Name = "brandTxtBox";
            this.brandTxtBox.Size = new System.Drawing.Size(350, 22);
            this.brandTxtBox.TabIndex = 2;

            this.gasolineLabel.Name = "gasolineLabel";
            this.gasolineLabel.Width = 150;
            this.gasolineLabel.Location = new System.Drawing.Point(20, 160);
            this.gasolineLabel.Text = "Марка бензина: ";

            this.gasolineTxtBox.Location = new System.Drawing.Point(20, 185);
            this.gasolineTxtBox.Name = "gasolineTxtBox";
            this.gasolineTxtBox.Size = new System.Drawing.Size(350, 22);
            this.gasolineTxtBox.TabIndex = 3;

            this.enginePowerLabel.Name = "enginePowerLabel";
            this.enginePowerLabel.Width = 150;
            this.enginePowerLabel.Location = new System.Drawing.Point(20, 210);
            this.enginePowerLabel.Text = "Мощность двигателя: ";
      
            this.enginePowerTxtBox.Location = new System.Drawing.Point(20, 235);
            this.enginePowerTxtBox.Name = "enginePowerTxtBox";
            this.enginePowerTxtBox.Size = new System.Drawing.Size(350, 22);
            this.enginePowerTxtBox.TabIndex = 4;
  
            this.volumeTankLabel.Name = "volumeTankLabel";
            this.volumeTankLabel.Width = 300;
            this.volumeTankLabel.Location = new System.Drawing.Point(20, 260);
            this.volumeTankLabel.Text = "Объём бака: ";
  
            this.volumeTankTxtBox.Location = new System.Drawing.Point(20, 285);
            this.volumeTankTxtBox.Name = "volumeTankTxtBox";
            this.volumeTankTxtBox.Size = new System.Drawing.Size(350, 22);
            this.volumeTankTxtBox.TabIndex = 5;
     
            this.remainingGasLabel.Name = "remainingGasLabel";
            this.remainingGasLabel.Width = 300;
            this.remainingGasLabel.Location = new System.Drawing.Point(20, 310);
            this.remainingGasLabel.Text = "Остаток бензина: ";
 
            this.remainingGasTxtBox.Location = new System.Drawing.Point(20, 335);
            this.remainingGasTxtBox.Name = "remainingGasTxtBox";
            this.remainingGasTxtBox.Size = new System.Drawing.Size(350, 22);
            this.remainingGasTxtBox.TabIndex = 6;

            this.volumeOilLabel.Name = "volumeOilLabel";
            this.volumeOilLabel.Width = 300;
            this.volumeOilLabel.Location = new System.Drawing.Point(20, 360);
            this.volumeOilLabel.Text = "Объём масла: ";

            this.volumeOilTxtBox.Location = new System.Drawing.Point(20, 385);
            this.volumeOilTxtBox.Name = "volumeOilTxtBox";
            this.volumeOilTxtBox.Size = new System.Drawing.Size(350, 22);
            this.volumeOilTxtBox.TabIndex = 7;

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(100, 470);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 24);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // AddProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.brandIdLabel);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.gasolineLabel);
            this.Controls.Add(this.remainingGasLabel);
            this.Controls.Add(this.volumeTankLabel);
            this.Controls.Add(this.enginePowerLabel);
            this.Controls.Add(this.volumeOilLabel);
            this.Controls.Add(this.surnameTxtBox);
            this.Controls.Add(this.brandIdTxtBox);
            this.Controls.Add(this.brandTxtBox);
            this.Controls.Add(this.gasolineTxtBox);
            this.Controls.Add(this.enginePowerTxtBox);
            this.Controls.Add(this.volumeTankTxtBox);
            this.Controls.Add(this.remainingGasTxtBox);
            this.Controls.Add(this.volumeOilTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddProperties";
            this.Text = "Добавить автомобиль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}