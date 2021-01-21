namespace Culminating_Hank_And_Lotem
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
            this.components = new System.ComponentModel.Container();
            this.tmrEndDay = new System.Windows.Forms.Timer(this.components);
            this.btnFeedAnimals = new System.Windows.Forms.Button();
            this.btnSellAnimals = new System.Windows.Forms.Button();
            this.btnDestroyHabitat = new System.Windows.Forms.Button();
            this.btnSearchByQuantity = new System.Windows.Forms.Button();
            this.btnSearchByDescription = new System.Windows.Forms.Button();
            this.btnSearchByAscendingQuantity = new System.Windows.Forms.Button();
            this.btnBuyForExistingHabitat = new System.Windows.Forms.Button();
            this.btnNewHabitat = new System.Windows.Forms.Button();
            this.btnViewHabitats = new System.Windows.Forms.Button();
            this.btnShowDescendingPrices = new System.Windows.Forms.Button();
            this.txtMinimumQuantity = new System.Windows.Forms.TextBox();
            this.txtDescriptionContaining = new System.Windows.Forms.TextBox();
            this.lblMinimumQuantity = new System.Windows.Forms.Label();
            this.lblDescriptionContaining = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblZoo = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.pnlAnimalInfo = new System.Windows.Forms.Panel();
            this.tmrMoney = new System.Windows.Forms.Timer(this.components);
            this.lblOutput2 = new System.Windows.Forms.Label();
            this.pnlAnimalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrEndDay
            // 
            this.tmrEndDay.Enabled = true;
            this.tmrEndDay.Interval = 2000;
            this.tmrEndDay.Tick += new System.EventHandler(this.tmrEndDay_Tick);
            // 
            // btnFeedAnimals
            // 
            this.btnFeedAnimals.Location = new System.Drawing.Point(28, 110);
            this.btnFeedAnimals.Name = "btnFeedAnimals";
            this.btnFeedAnimals.Size = new System.Drawing.Size(104, 52);
            this.btnFeedAnimals.TabIndex = 0;
            this.btnFeedAnimals.Text = "Feed Animals";
            this.btnFeedAnimals.UseVisualStyleBackColor = true;
            this.btnFeedAnimals.Click += new System.EventHandler(this.btnFeedAnimals_Click);
            // 
            // btnSellAnimals
            // 
            this.btnSellAnimals.Location = new System.Drawing.Point(28, 170);
            this.btnSellAnimals.Name = "btnSellAnimals";
            this.btnSellAnimals.Size = new System.Drawing.Size(104, 49);
            this.btnSellAnimals.TabIndex = 1;
            this.btnSellAnimals.Text = "Sell Animal From Existing Habitat";
            this.btnSellAnimals.UseVisualStyleBackColor = true;
            this.btnSellAnimals.Click += new System.EventHandler(this.btnSellAnimals_Click);
            // 
            // btnDestroyHabitat
            // 
            this.btnDestroyHabitat.Location = new System.Drawing.Point(28, 225);
            this.btnDestroyHabitat.Name = "btnDestroyHabitat";
            this.btnDestroyHabitat.Size = new System.Drawing.Size(104, 49);
            this.btnDestroyHabitat.TabIndex = 2;
            this.btnDestroyHabitat.Text = "Destroy Existing Habitat";
            this.btnDestroyHabitat.UseVisualStyleBackColor = true;
            this.btnDestroyHabitat.Click += new System.EventHandler(this.btnDestroyHabitat_Click);
            // 
            // btnSearchByQuantity
            // 
            this.btnSearchByQuantity.Location = new System.Drawing.Point(28, 280);
            this.btnSearchByQuantity.Name = "btnSearchByQuantity";
            this.btnSearchByQuantity.Size = new System.Drawing.Size(104, 49);
            this.btnSearchByQuantity.TabIndex = 3;
            this.btnSearchByQuantity.Text = "Show Only Habitats With At Least...";
            this.btnSearchByQuantity.UseVisualStyleBackColor = true;
            this.btnSearchByQuantity.Click += new System.EventHandler(this.btnSearchByQuantity_Click);
            // 
            // btnSearchByDescription
            // 
            this.btnSearchByDescription.Location = new System.Drawing.Point(28, 337);
            this.btnSearchByDescription.Name = "btnSearchByDescription";
            this.btnSearchByDescription.Size = new System.Drawing.Size(104, 43);
            this.btnSearchByDescription.TabIndex = 4;
            this.btnSearchByDescription.Text = "Show Habitats By Matching Description";
            this.btnSearchByDescription.UseVisualStyleBackColor = true;
            this.btnSearchByDescription.Click += new System.EventHandler(this.btnSearchByDescription_Click);
            // 
            // btnSearchByAscendingQuantity
            // 
            this.btnSearchByAscendingQuantity.Location = new System.Drawing.Point(28, 389);
            this.btnSearchByAscendingQuantity.Name = "btnSearchByAscendingQuantity";
            this.btnSearchByAscendingQuantity.Size = new System.Drawing.Size(104, 45);
            this.btnSearchByAscendingQuantity.TabIndex = 5;
            this.btnSearchByAscendingQuantity.Text = "Search Animals By Ascending Quantity";
            this.btnSearchByAscendingQuantity.UseVisualStyleBackColor = true;
            this.btnSearchByAscendingQuantity.Click += new System.EventHandler(this.btnSearchByAscendingQuantity_Click);
            // 
            // btnBuyForExistingHabitat
            // 
            this.btnBuyForExistingHabitat.Location = new System.Drawing.Point(169, 110);
            this.btnBuyForExistingHabitat.Name = "btnBuyForExistingHabitat";
            this.btnBuyForExistingHabitat.Size = new System.Drawing.Size(107, 52);
            this.btnBuyForExistingHabitat.TabIndex = 6;
            this.btnBuyForExistingHabitat.Text = "Buy Animal For Existing Habitat";
            this.btnBuyForExistingHabitat.UseVisualStyleBackColor = true;
            this.btnBuyForExistingHabitat.Click += new System.EventHandler(this.btnBuyForExistingHabitat_Click);
            // 
            // btnNewHabitat
            // 
            this.btnNewHabitat.Location = new System.Drawing.Point(169, 170);
            this.btnNewHabitat.Name = "btnNewHabitat";
            this.btnNewHabitat.Size = new System.Drawing.Size(107, 49);
            this.btnNewHabitat.TabIndex = 7;
            this.btnNewHabitat.Text = "Build New Habitat";
            this.btnNewHabitat.UseVisualStyleBackColor = true;
            this.btnNewHabitat.Click += new System.EventHandler(this.btnNewHabitat_Click);
            // 
            // btnViewHabitats
            // 
            this.btnViewHabitats.Location = new System.Drawing.Point(169, 225);
            this.btnViewHabitats.Name = "btnViewHabitats";
            this.btnViewHabitats.Size = new System.Drawing.Size(107, 49);
            this.btnViewHabitats.TabIndex = 8;
            this.btnViewHabitats.Text = "View All Habitats";
            this.btnViewHabitats.UseVisualStyleBackColor = true;
            this.btnViewHabitats.Click += new System.EventHandler(this.btnViewHabitats_Click);
            // 
            // btnShowDescendingPrices
            // 
            this.btnShowDescendingPrices.Location = new System.Drawing.Point(169, 391);
            this.btnShowDescendingPrices.Name = "btnShowDescendingPrices";
            this.btnShowDescendingPrices.Size = new System.Drawing.Size(107, 43);
            this.btnShowDescendingPrices.TabIndex = 9;
            this.btnShowDescendingPrices.Text = "Show Animals by Descending Price";
            this.btnShowDescendingPrices.UseVisualStyleBackColor = true;
            this.btnShowDescendingPrices.Click += new System.EventHandler(this.btnShowDescendingPrices_Click);
            // 
            // txtMinimumQuantity
            // 
            this.txtMinimumQuantity.Location = new System.Drawing.Point(169, 309);
            this.txtMinimumQuantity.Name = "txtMinimumQuantity";
            this.txtMinimumQuantity.Size = new System.Drawing.Size(107, 20);
            this.txtMinimumQuantity.TabIndex = 10;
            // 
            // txtDescriptionContaining
            // 
            this.txtDescriptionContaining.Location = new System.Drawing.Point(169, 360);
            this.txtDescriptionContaining.Name = "txtDescriptionContaining";
            this.txtDescriptionContaining.Size = new System.Drawing.Size(107, 20);
            this.txtDescriptionContaining.TabIndex = 11;
            // 
            // lblMinimumQuantity
            // 
            this.lblMinimumQuantity.AutoSize = true;
            this.lblMinimumQuantity.Location = new System.Drawing.Point(169, 290);
            this.lblMinimumQuantity.Name = "lblMinimumQuantity";
            this.lblMinimumQuantity.Size = new System.Drawing.Size(93, 13);
            this.lblMinimumQuantity.TabIndex = 12;
            this.lblMinimumQuantity.Text = "Minimum Quantity:";
            // 
            // lblDescriptionContaining
            // 
            this.lblDescriptionContaining.AutoSize = true;
            this.lblDescriptionContaining.Location = new System.Drawing.Point(168, 341);
            this.lblDescriptionContaining.Name = "lblDescriptionContaining";
            this.lblDescriptionContaining.Size = new System.Drawing.Size(116, 13);
            this.lblDescriptionContaining.TabIndex = 13;
            this.lblDescriptionContaining.Text = "Description Containing:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(300, 99);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 14;
            // 
            // lblZoo
            // 
            this.lblZoo.AutoSize = true;
            this.lblZoo.Location = new System.Drawing.Point(25, 9);
            this.lblZoo.Name = "lblZoo";
            this.lblZoo.Size = new System.Drawing.Size(224, 13);
            this.lblZoo.TabIndex = 15;
            this.lblZoo.Text = "The Zoo - Open from 9:00 to 17:00 every day!";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(25, 38);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(37, 13);
            this.lblMoney.TabIndex = 16;
            this.lblMoney.Text = "$7000";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(25, 60);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(29, 13);
            this.lblDay.TabIndex = 17;
            this.lblDay.Text = "Day:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(25, 73);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 13);
            this.lblTime.TabIndex = 18;
            this.lblTime.Text = "Time:";
            // 
            // btnSearch1
            // 
            this.btnSearch1.Location = new System.Drawing.Point(330, 50);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(75, 23);
            this.btnSearch1.TabIndex = 19;
            this.btnSearch1.Text = "< Search";
            this.btnSearch1.UseVisualStyleBackColor = true;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click_1);
            // 
            // btnCancel1
            // 
            this.btnCancel1.Location = new System.Drawing.Point(416, 50);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(75, 23);
            this.btnCancel1.TabIndex = 20;
            this.btnCancel1.Text = "Cancel";
            this.btnCancel1.UseVisualStyleBackColor = true;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click_1);
            // 
            // btnSearch2
            // 
            this.btnSearch2.Location = new System.Drawing.Point(498, 50);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(75, 23);
            this.btnSearch2.TabIndex = 21;
            this.btnSearch2.Text = "Search >";
            this.btnSearch2.UseVisualStyleBackColor = true;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click_1);
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(17, 174);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(75, 23);
            this.btnCancel2.TabIndex = 22;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click_1);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(112, 174);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 23;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(3, 11);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(120, 13);
            this.lblDisplay.TabIndex = 24;
            this.lblDisplay.Text = "Input Animal Information";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 13);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "name: ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(5, 96);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(64, 13);
            this.lblDescription.TabIndex = 26;
            this.lblDescription.Text = "description: ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(30, 128);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(36, 13);
            this.lblPrice.TabIndex = 27;
            this.lblPrice.Text = "price: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 28;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(91, 96);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 29;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(91, 125);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 30;
            // 
            // pnlAnimalInfo
            // 
            this.pnlAnimalInfo.Controls.Add(this.lblDisplay);
            this.pnlAnimalInfo.Controls.Add(this.txtPrice);
            this.pnlAnimalInfo.Controls.Add(this.btnSubmit);
            this.pnlAnimalInfo.Controls.Add(this.txtDescription);
            this.pnlAnimalInfo.Controls.Add(this.txtName);
            this.pnlAnimalInfo.Controls.Add(this.btnCancel2);
            this.pnlAnimalInfo.Controls.Add(this.lblName);
            this.pnlAnimalInfo.Controls.Add(this.lblDescription);
            this.pnlAnimalInfo.Controls.Add(this.lblPrice);
            this.pnlAnimalInfo.Location = new System.Drawing.Point(642, 29);
            this.pnlAnimalInfo.Name = "pnlAnimalInfo";
            this.pnlAnimalInfo.Size = new System.Drawing.Size(206, 235);
            this.pnlAnimalInfo.TabIndex = 0;
            // 
            // tmrMoney
            // 
            this.tmrMoney.Enabled = true;
            this.tmrMoney.Tick += new System.EventHandler(this.tmrMoney_Tick);
            // 
            // lblOutput2
            // 
            this.lblOutput2.AutoSize = true;
            this.lblOutput2.Location = new System.Drawing.Point(624, 298);
            this.lblOutput2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutput2.Name = "lblOutput2";
            this.lblOutput2.Size = new System.Drawing.Size(0, 13);
            this.lblOutput2.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 545);
            this.Controls.Add(this.lblOutput2);
            this.Controls.Add(this.pnlAnimalInfo);
            this.Controls.Add(this.btnSearch2);
            this.Controls.Add(this.btnCancel1);
            this.Controls.Add(this.btnSearch1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblZoo);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblDescriptionContaining);
            this.Controls.Add(this.lblMinimumQuantity);
            this.Controls.Add(this.txtDescriptionContaining);
            this.Controls.Add(this.txtMinimumQuantity);
            this.Controls.Add(this.btnShowDescendingPrices);
            this.Controls.Add(this.btnViewHabitats);
            this.Controls.Add(this.btnNewHabitat);
            this.Controls.Add(this.btnBuyForExistingHabitat);
            this.Controls.Add(this.btnSearchByAscendingQuantity);
            this.Controls.Add(this.btnSearchByDescription);
            this.Controls.Add(this.btnSearchByQuantity);
            this.Controls.Add(this.btnDestroyHabitat);
            this.Controls.Add(this.btnSellAnimals);
            this.Controls.Add(this.btnFeedAnimals);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlAnimalInfo.ResumeLayout(false);
            this.pnlAnimalInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrEndDay;
        private System.Windows.Forms.Button btnFeedAnimals;
        private System.Windows.Forms.Button btnSellAnimals;
        private System.Windows.Forms.Button btnDestroyHabitat;
        private System.Windows.Forms.Button btnSearchByQuantity;
        private System.Windows.Forms.Button btnSearchByDescription;
        private System.Windows.Forms.Button btnSearchByAscendingQuantity;
        private System.Windows.Forms.Button btnBuyForExistingHabitat;
        private System.Windows.Forms.Button btnNewHabitat;
        private System.Windows.Forms.Button btnViewHabitats;
        private System.Windows.Forms.Button btnShowDescendingPrices;
        private System.Windows.Forms.TextBox txtMinimumQuantity;
        private System.Windows.Forms.TextBox txtDescriptionContaining;
        private System.Windows.Forms.Label lblMinimumQuantity;
        private System.Windows.Forms.Label lblDescriptionContaining;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblZoo;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Panel pnlHide;
        private System.Windows.Forms.Panel pnlAnimalInfo;
        private System.Windows.Forms.Timer tmrMoney;
        private System.Windows.Forms.Label lblOutput2;
    }
}

