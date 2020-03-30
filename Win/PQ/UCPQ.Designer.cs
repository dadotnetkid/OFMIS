namespace Win.PQ
{
    partial class UCPQ
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
            this.PQGridControl = new DevExpress.XtraGrid.GridControl();
            this.PQGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.PQGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PQGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PQGridControl
            // 
            this.PQGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PQGridControl.Location = new System.Drawing.Point(0, 0);
            this.PQGridControl.MainView = this.PQGridView;
            this.PQGridControl.Name = "PQGridControl";
            this.PQGridControl.Size = new System.Drawing.Size(632, 415);
            this.PQGridControl.TabIndex = 0;
            this.PQGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PQGridView});
            // 
            // PQGridView
            // 
            this.PQGridView.GridControl = this.PQGridControl;
            this.PQGridView.Name = "PQGridView";
            this.PQGridView.OptionsView.ShowGroupPanel = false;
            // 
            // UCPQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PQGridControl);
            this.Name = "UCPQ";
            this.Size = new System.Drawing.Size(632, 415);
            ((System.ComponentModel.ISupportInitialize)(this.PQGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PQGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl PQGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView PQGridView;
    }
}
