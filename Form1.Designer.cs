namespace PretendGoogleMaps
{
    partial class frm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtBoxStreet = new System.Windows.Forms.TextBox();
            this.txtBoxZipCode = new System.Windows.Forms.TextBox();
            this.txtBoxState = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.streetLbl = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.stateLbl = new System.Windows.Forms.Label();
            this.zipcodeLbl = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.zipcodeLbl);
            this.splitContainer1.Panel1.Controls.Add(this.stateLbl);
            this.splitContainer1.Panel1.Controls.Add(this.cityLbl);
            this.splitContainer1.Panel1.Controls.Add(this.streetLbl);
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxCity);
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxState);
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxZipCode);
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxStreet);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(1188, 682);
            this.splitContainer1.SplitterDistance = 396;
            this.splitContainer1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(788, 682);
            this.webBrowser1.TabIndex = 0;
            // 
            // txtBoxStreet
            // 
            this.txtBoxStreet.Location = new System.Drawing.Point(133, 239);
            this.txtBoxStreet.Name = "txtBoxStreet";
            this.txtBoxStreet.Size = new System.Drawing.Size(199, 26);
            this.txtBoxStreet.TabIndex = 0;
            // 
            // txtBoxZipCode
            // 
            this.txtBoxZipCode.Location = new System.Drawing.Point(133, 437);
            this.txtBoxZipCode.Name = "txtBoxZipCode";
            this.txtBoxZipCode.Size = new System.Drawing.Size(199, 26);
            this.txtBoxZipCode.TabIndex = 1;
            // 
            // txtBoxState
            // 
            this.txtBoxState.Location = new System.Drawing.Point(133, 375);
            this.txtBoxState.Name = "txtBoxState";
            this.txtBoxState.Size = new System.Drawing.Size(199, 26);
            this.txtBoxState.TabIndex = 2;
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(133, 301);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(199, 26);
            this.txtBoxCity.TabIndex = 3;
            // 
            // streetLbl
            // 
            this.streetLbl.AutoSize = true;
            this.streetLbl.Location = new System.Drawing.Point(37, 242);
            this.streetLbl.Name = "streetLbl";
            this.streetLbl.Size = new System.Drawing.Size(53, 20);
            this.streetLbl.TabIndex = 4;
            this.streetLbl.Text = "Street";
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Location = new System.Drawing.Point(37, 304);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(35, 20);
            this.cityLbl.TabIndex = 5;
            this.cityLbl.Text = "City";
            // 
            // stateLbl
            // 
            this.stateLbl.AutoSize = true;
            this.stateLbl.Location = new System.Drawing.Point(37, 378);
            this.stateLbl.Name = "stateLbl";
            this.stateLbl.Size = new System.Drawing.Size(48, 20);
            this.stateLbl.TabIndex = 6;
            this.stateLbl.Text = "State";
            // 
            // zipcodeLbl
            // 
            this.zipcodeLbl.AutoSize = true;
            this.zipcodeLbl.Location = new System.Drawing.Point(37, 440);
            this.zipcodeLbl.Name = "zipcodeLbl";
            this.zipcodeLbl.Size = new System.Drawing.Size(73, 20);
            this.zipcodeLbl.TabIndex = 7;
            this.zipcodeLbl.Text = "Zip Code";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(157, 487);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 35);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 682);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm";
            this.Text = "PretendGoogleMaps";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label zipcodeLbl;
        private System.Windows.Forms.Label stateLbl;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label streetLbl;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.TextBox txtBoxState;
        private System.Windows.Forms.TextBox txtBoxZipCode;
        private System.Windows.Forms.TextBox txtBoxStreet;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

