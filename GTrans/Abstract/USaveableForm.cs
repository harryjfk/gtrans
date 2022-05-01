using System.Windows.Forms;
using DevExpress.XtraEditors;
using ACINOX.DBT.DSDllTableAdapters;

namespace GTrans.Abstract
{
    public partial class SaveableForm : CaptionWindow
    {

        public SaveableForm()
        {
        }
       
        public SaveableForm(FrmMain main) : base(main)
        {
            FormClosing+= SaveableForm_FormClosing;
            InitializeComponent();
        }
  
        protected void CheckEdit()
        {
            if (Changed && !Loading)
                Text = DefaultText + @"*";
            else
                Text = DefaultText;

        }
        public bool IsEdited()
        {
            return Changed;
        }

        public virtual bool Save()
        {
            return ValidateAll();
        }

        public string DefaultText { get; set; }
        protected  virtual  bool GetChanged()
        {
            return false;
        }
        public bool Changed
        {
            get { return GetChanged(); }
             set
             {
             //   if (Loading == false)
                //     Ch = value; CheckEdit();
             }
        }
        public bool Loading { get; set; }
        public bool CheckClose()
        {
            if (IsEdited())
            {
                var s = ShowDialog("Los datos del formulario han cambiado desea guardarlos?", "Guardar",
                                        MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
                bool r = false;
                if (s== DialogResult.Yes)
                    r=Save();
                var res = (s == DialogResult.Cancel) || (s == DialogResult.Yes && !r);
                if (HintPanel != null) 
                HintPanel.Visible = s == DialogResult.Yes && !r;
                return res;
            }
            else
            return false;
        }

 
        private void SaveableForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = CheckClose();
        }
        protected virtual bool  ValidateAll()
        {
            return true;
        }
        protected DialogResult ShowDialog(string msg,string title,MessageBoxButtons btns,MessageBoxIcon ic)
        {
            return XtraMessageBox.Show(msg, title, btns,ic);
        }
    }
}