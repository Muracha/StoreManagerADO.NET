using StoreManager.Models;
using StoreManager.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StoreManager.App.DetailsForm
{
    public partial class UserDetails2 : Form
    {
        private readonly int _id;
        private readonly UserService _userService;
        private readonly ErrorProvider _errorProvider;
        public bool EditMode => _id != 0;

        public UserDetails2(int id = 0)
        {
            InitializeComponent();

            _id = id;
            _userService = new UserService();
            _errorProvider = new ErrorProvider();

            if (EditMode)
            {
                LoadData();
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                SaveData();
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// კითხულობს მონაცემთა ბაზიდან ჩანაწერს და ასახავს ვიზუალურ კომპონენტებში.
        /// </summary>
        private void LoadData()
        {
            try
            {
                var user = _userService.Get(_id);
                txtUserID.Text = user.ID.ToString();
                txtUserName.Text = user.Username;
                txtPassword.Text = user.Password;
                ckbIsActive.Checked = user.IsActive;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ქმნის ობიექტს ვიზუალურ კომპონენტებში შეყვანილი ინფორმაციის საფუძველზე
        /// და წერს მონაცემთა ბაზაში.
        /// </summary>
        private void SaveData()
        {
            ValidateData();

            if (!EditMode)
            {
                _userService.Insert(LoadUserModel());
            }
            else
            {
                _userService.Update(LoadUserModel());
            }      
        }

        /// <summary>
        /// ჩატვირთავს ობიექტს ვიზუალური კომპონენტებიდან EditMode_ის მიხედვით. 
        /// </summary>
        private User LoadUserModel()
        {
            var user = new User();
            if (!EditMode)
            {
                user.ID = int.Parse(txtUserID.Text);
                user.Username = txtUserName.Text;
                user.Password = txtPassword.Text;
                return user;
            }
            else
            {
                user.ID = int.Parse(txtUserID.Text);
                user.Username = txtUserName.Text;
                user.IsActive = ckbIsActive.Checked;
                return user;
            }
        }

        /// <summary>
        /// ამოწმებს შეყვანილ ინფორმაციას მართებულობაზე.
        /// </summary>
        private void ValidateData()
        {
            if (EditMode)
                CheckDuplicateUserName();
            else
                CheckIsNullAllTextBox();
        }

        /// <summary>
        /// ამოწმებს ყველა TextBox, არის თუ არა შევსებული.
        /// </summary>
        private void CheckIsNullAllTextBox()
        {
            foreach (var txtBox in this.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrWhiteSpace(txtBox.Text))
                {
                    _errorProvider.SetError(txtBox, "Fill the missed lines !!!");
                }
                else
                {
                    _errorProvider.SetError(txtBox, string.Empty);
                }
            }
        }

        /// <summary>
        /// ამოწმებს არსებობს თუ არა მზგავსი UserName ბაზაში.
        /// </summary>
        /// 

        // ვერსია 1 LINQ-ით. არ მუშაობს რადგან მოაქვს მხოლოდ IsDelete=0

        //private void CheckDuplicateUserName()
        //{
        //    var result = _userService.Select().
        //        Where(r => (r.Username == txtUserName.Text && r.ID != int.Parse(txtUserID.Text)));

        //    if (result.Count() >= 1)
        //        throw new Exception("A similar User name already exists!!!");
        //}

        // ვერსია 2 SelectAll() მეთოდის და LINQ-ის  გამოყენებით .
        private void CheckDuplicateUserName()
        {
            var result =_userService.SelectAll().
                Where(r => (r.Username == txtUserName.Text && r.ID != int.Parse(txtUserID.Text)));
           
            if (result.Count() >= 1)
                throw new Exception("A similar User name already exists!!!");
        }
    }
}
