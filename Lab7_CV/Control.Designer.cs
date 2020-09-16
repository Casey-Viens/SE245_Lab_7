namespace Lab5_CV
{
    partial class Control
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
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnSearchPersons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(101, 118);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(157, 31);
            this.btnAddPerson.TabIndex = 0;
            this.btnAddPerson.Text = "Add a Contact";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnSearchPersons
            // 
            this.btnSearchPersons.Location = new System.Drawing.Point(337, 118);
            this.btnSearchPersons.Name = "btnSearchPersons";
            this.btnSearchPersons.Size = new System.Drawing.Size(157, 31);
            this.btnSearchPersons.TabIndex = 1;
            this.btnSearchPersons.Text = "Search Contacts";
            this.btnSearchPersons.UseVisualStyleBackColor = true;
            this.btnSearchPersons.Click += new System.EventHandler(this.btnSearchPersons_Click);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 272);
            this.Controls.Add(this.btnSearchPersons);
            this.Controls.Add(this.btnAddPerson);
            this.Name = "Control";
            this.Text = "Control";
            this.Load += new System.EventHandler(this.Control_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnSearchPersons;
    }
}