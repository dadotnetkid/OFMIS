using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpers.Custom
{
    public class MultiColumnComboBox : ComboBox
    {
        private MultiColumnComboBoxPopup _multiColumnComboBoxPopup;

        public MultiColumnComboBox()
        {
            this.Dock = DockStyle.Fill;
        }
        protected override void OnDropDown(EventArgs e)
        {
            Form parent = this.FindForm();
            this.MultiColumnComboBoxPopup = new MultiColumnComboBoxPopup();
            MultiColumnComboBoxPopup.Location = new Point(parent.Left + this.Left + 4, parent.Top + this.Bottom + this.Height);
            MultiColumnComboBoxPopup.Show();

            base.OnDropDown(e);
        }

        public MultiColumnComboBoxPopup MultiColumnComboBoxPopup
        {
            get
            {
                if (_multiColumnComboBoxPopup == null)
                    _multiColumnComboBoxPopup = new MultiColumnComboBoxPopup();
                return _multiColumnComboBoxPopup;
            }
            set => _multiColumnComboBoxPopup = value;
        }
    }

    public class MultiColumnComboBoxPopup : Form
    {
        private Container components;
        public ListView ListView;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
        }
        public MultiColumnComboBoxPopup()
        {
            this.ListView = new System.Windows.Forms.ListView()
            {
               
            };
            this.SuspendLayout();
            // 
            // lstvMyView
            // 
            this.ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView.FullRowSelect = true;
            this.ListView.GridLines = true;
            this.ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListView.MultiSelect = false;
            this.ListView.Name = "lstvMyView";
            this.ListView.Size = new System.Drawing.Size(292, 88);
            this.ListView.TabIndex = 0;

            this.Name = "MultiColumnComboPopup";
            this.Controls.Add(this.ListView);
        }
    }

}
