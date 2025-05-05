namespace FoodApp
{
    partial class FoodCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBoxFoodPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            labelFoodName = new Label();
            labelPrices = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoodPicture).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxFoodPicture
            // 
            pictureBoxFoodPicture.ImageRotate = 0F;
            pictureBoxFoodPicture.Location = new Point(13, 13);
            pictureBoxFoodPicture.Name = "pictureBoxFoodPicture";
            pictureBoxFoodPicture.ShadowDecoration.CustomizableEdges = customizableEdges1;
            pictureBoxFoodPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pictureBoxFoodPicture.Size = new Size(163, 140);
            pictureBoxFoodPicture.TabIndex = 0;
            pictureBoxFoodPicture.TabStop = false;
            // 
            // labelFoodName
            // 
            labelFoodName.AutoSize = true;
            labelFoodName.Location = new Point(58, 169);
            labelFoodName.Name = "labelFoodName";
            labelFoodName.Size = new Size(69, 15);
            labelFoodName.TabIndex = 1;
            labelFoodName.Text = "Food Name";
            // 
            // labelPrices
            // 
            labelPrices.AutoSize = true;
            labelPrices.Location = new Point(58, 184);
            labelPrices.Name = "labelPrices";
            labelPrices.Size = new Size(33, 15);
            labelPrices.TabIndex = 2;
            labelPrices.Text = "Price";
            // 
            // FoodCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelPrices);
            Controls.Add(labelFoodName);
            Controls.Add(pictureBoxFoodPicture);
            Name = "FoodCard";
            Size = new Size(191, 208);
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoodPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label labelFoodName;
        public Label labelPrices;
        public Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxFoodPicture;
    }
}
