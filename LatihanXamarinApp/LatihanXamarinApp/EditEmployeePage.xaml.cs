using LatihanXamarinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LatihanXamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditEmployeePage : ContentPage
    {
        public EditEmployeePage()
        {
            InitializeComponent();
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            var editEmp = new Employee
            {
                EmpId = Convert.ToInt64(entryID.Text),
                EmpName = entryName.Text,
                Department = entryDepartment.Text,
                Designation = entryDesignation.Text,
                Qualification = entryQualification.Text
            };
            try
            {
                App.DbAccess.EditEmployee(editEmp);
                await DisplayAlert("Keterangan", $"Data employee {editEmp.EmpName} berhasil diedit", "OK");
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Kesalahan", ex.Message, "OK");
            }
        }

        private void btnDelete_Clicked(object sender, EventArgs e)
        {

        }
    }
}