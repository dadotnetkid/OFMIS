namespace Win.OB
{
    partial class ucObligations
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucObligations));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.entityServerModeSource1 = new DevExpress.Data.Linq.EntityServerModeSource();
            this.gridObligation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit8 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit9 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit10 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit11 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit12 = new DevExpress.XtraEditors.TextEdit();
            this.colDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDeleteRepoOBR = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridObligation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit11.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit12.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteRepoOBR)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(438, 573);
            this.panelControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.entityServerModeSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 63);
            this.gridControl1.MainView = this.gridObligation;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDeleteRepoOBR});
            this.gridControl1.Size = new System.Drawing.Size(434, 508);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridObligation});
            // 
            // entityServerModeSource1
            // 
            this.entityServerModeSource1.DefaultSorting = "Id ASC";
            this.entityServerModeSource1.ElementType = typeof(Models.Obligations);
            this.entityServerModeSource1.KeyExpression = "Id";
            // 
            // gridObligation
            // 
            this.gridObligation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDel,
            this.colDate,
            this.colAmount,
            this.colDescription});
            this.gridObligation.GridControl = this.gridControl1;
            this.gridObligation.Name = "gridObligation";
            this.gridObligation.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridObligation.OptionsBehavior.Editable = false;
            this.gridObligation.OptionsLayout.Columns.AddNewColumns = false;
            this.gridObligation.OptionsView.ShowGroupPanel = false;
            this.gridObligation.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            this.colDate.Width = 129;
            // 
            // colAmount
            // 
            this.colAmount.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.colAmount.AppearanceCell.Options.UseForeColor = true;
            this.colAmount.Caption = "Amount";
            this.colAmount.DisplayFormat.FormatString = "n2";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 2;
            this.colAmount.Width = 129;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 131;
            // 
            // panelControl2
            // 
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(434, 61);
            this.panelControl2.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnNew);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(438, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(815, 61);
            this.panelControl3.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnNew.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.Location = new System.Drawing.Point(6, 33);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(102, 23);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "Add OBR";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(443, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Date";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(443, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Control";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(443, 113);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Payee";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(443, 135);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Office";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(443, 157);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Address";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(443, 180);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(71, 13);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "OR Description";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(518, 67);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Properties.UseReadOnlyAppearance = false;
            this.textEdit1.Size = new System.Drawing.Size(224, 20);
            this.textEdit1.TabIndex = 7;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(518, 89);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.Properties.UseReadOnlyAppearance = false;
            this.textEdit2.Size = new System.Drawing.Size(224, 20);
            this.textEdit2.TabIndex = 7;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(518, 111);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.ReadOnly = true;
            this.textEdit3.Properties.UseReadOnlyAppearance = false;
            this.textEdit3.Size = new System.Drawing.Size(433, 20);
            this.textEdit3.TabIndex = 7;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(518, 133);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.ReadOnly = true;
            this.textEdit4.Properties.UseReadOnlyAppearance = false;
            this.textEdit4.Size = new System.Drawing.Size(433, 20);
            this.textEdit4.TabIndex = 7;
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(518, 155);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.ReadOnly = true;
            this.textEdit5.Properties.UseReadOnlyAppearance = false;
            this.textEdit5.Size = new System.Drawing.Size(433, 20);
            this.textEdit5.TabIndex = 7;
            // 
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(518, 177);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.ReadOnly = true;
            this.textEdit6.Properties.UseReadOnlyAppearance = false;
            this.textEdit6.Size = new System.Drawing.Size(433, 20);
            this.textEdit6.TabIndex = 7;
            // 
            // textEdit7
            // 
            this.textEdit7.Location = new System.Drawing.Point(518, 199);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.ReadOnly = true;
            this.textEdit7.Properties.UseReadOnlyAppearance = false;
            this.textEdit7.Size = new System.Drawing.Size(433, 20);
            this.textEdit7.TabIndex = 9;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(443, 202);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(70, 13);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "Budget Officer";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(443, 224);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(61, 13);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Chief Officer";
            // 
            // textEdit8
            // 
            this.textEdit8.Location = new System.Drawing.Point(518, 221);
            this.textEdit8.Name = "textEdit8";
            this.textEdit8.Properties.ReadOnly = true;
            this.textEdit8.Properties.UseReadOnlyAppearance = false;
            this.textEdit8.Size = new System.Drawing.Size(433, 20);
            this.textEdit8.TabIndex = 9;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(443, 243);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(37, 13);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "Position";
            // 
            // textEdit9
            // 
            this.textEdit9.Location = new System.Drawing.Point(518, 243);
            this.textEdit9.Name = "textEdit9";
            this.textEdit9.Properties.ReadOnly = true;
            this.textEdit9.Properties.UseReadOnlyAppearance = false;
            this.textEdit9.Size = new System.Drawing.Size(433, 20);
            this.textEdit9.TabIndex = 9;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(747, 67);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(31, 13);
            this.labelControl10.TabIndex = 2;
            this.labelControl10.Text = "Status";
            // 
            // textEdit10
            // 
            this.textEdit10.Location = new System.Drawing.Point(803, 67);
            this.textEdit10.Name = "textEdit10";
            this.textEdit10.Properties.ReadOnly = true;
            this.textEdit10.Properties.UseReadOnlyAppearance = false;
            this.textEdit10.Size = new System.Drawing.Size(148, 20);
            this.textEdit10.TabIndex = 7;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(747, 89);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(57, 13);
            this.labelControl11.TabIndex = 2;
            this.labelControl11.Text = "Budget Ctl. ";
            // 
            // textEdit11
            // 
            this.textEdit11.Location = new System.Drawing.Point(803, 89);
            this.textEdit11.Name = "textEdit11";
            this.textEdit11.Properties.ReadOnly = true;
            this.textEdit11.Properties.UseReadOnlyAppearance = false;
            this.textEdit11.Size = new System.Drawing.Size(148, 20);
            this.textEdit11.TabIndex = 7;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(747, 268);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(37, 13);
            this.labelControl12.TabIndex = 8;
            this.labelControl12.Text = "Amount";
            // 
            // textEdit12
            // 
            this.textEdit12.Location = new System.Drawing.Point(803, 265);
            this.textEdit12.Name = "textEdit12";
            this.textEdit12.Properties.ReadOnly = true;
            this.textEdit12.Properties.UseReadOnlyAppearance = false;
            this.textEdit12.Size = new System.Drawing.Size(148, 20);
            this.textEdit12.TabIndex = 9;
            // 
            // colDel
            // 
            this.colDel.ColumnEdit = this.btnDeleteRepoOBR;
            this.colDel.Name = "colDel";
            this.colDel.Visible = true;
            this.colDel.VisibleIndex = 0;
            this.colDel.Width = 20;
            // 
            // btnDeleteRepoOBR
            // 
            this.btnDeleteRepoOBR.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnDeleteRepoOBR.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDeleteRepoOBR.Name = "btnDeleteRepoOBR";
            this.btnDeleteRepoOBR.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDeleteRepoOBR.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDeleteRepoOBR_ButtonClick);
            // 
            // ucObligations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textEdit12);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.textEdit9);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.textEdit8);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.textEdit7);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.textEdit6);
            this.Controls.Add(this.textEdit5);
            this.Controls.Add(this.textEdit4);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit11);
            this.Controls.Add(this.textEdit10);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucObligations";
            this.Size = new System.Drawing.Size(1253, 573);
            this.Load += new System.EventHandler(this.ucObligations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridObligation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit11.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit12.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteRepoOBR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridObligation;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.Data.Linq.EntityServerModeSource entityServerModeSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textEdit8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit textEdit9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit textEdit10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit textEdit11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit textEdit12;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraGrid.Columns.GridColumn colDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeleteRepoOBR;
    }
}
