﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using RestaurantSystem.Controllers;
using RestaurantSystem.Data.Models;

namespace RestaurantSystem
{
    public partial class AddUser : Form
    {
        DBController controller;
        public AddUser(DBController controller)
        {
            this.controller = controller;
            InitializeComponent();
            LoadEmployees();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label1.ForeColor = ThemeColor.SecondaryColor;
            label2.ForeColor = ThemeColor.PrimaryColor;
            label3.ForeColor = ThemeColor.SecondaryColor;
            label4.ForeColor = ThemeColor.PrimaryColor;
        }

        public void LoadEmployees()
        {
            List<Employee> employees = FormToDBController.SelectEmployees(ref controller);
            foreach (Employee emp in employees)
            {
                StaffcomboBox.Items.Add(emp.FirstName + " " + emp.LastName);
            }
        }

        private void StaffcomboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadEmployeeProperties();
        }

        public void LoadEmployeeProperties()
        {
            string employeeName = StaffcomboBox.SelectedItem.ToString();
            string employeeFirstName = employeeName.Split(' ')[0];
            string employeeLastName = employeeName.Split(' ')[1];

            JobPosition.Text = FormToDBController.GetEmployerJobPosition(ref controller, employeeFirstName, employeeLastName);

            usernameTextbox.Text = FormToDBController.GetEmployerUserName(ref controller, employeeFirstName, employeeLastName);

            passwordTextbox.Text = FormToDBController.GetEmployerPassword(ref controller, employeeFirstName, employeeLastName);
        }

        private bool ValidPass()
        {
            bool passLength = false, hasDigit = false, hasUpper = false, hasLower = false, hasSpecialChar = false;

            if (passwordTextbox.TextLength >= 6)
            {
                passLength = true;
            }
            else
            {
                label5.Text = "Моля въведете парола с поне 6 символа.";
                return false;
            }

            foreach (char c in passwordTextbox.Text)
            {
                if (char.IsDigit(c))
                    hasDigit = true;

                else if (char.IsUpper(c))
                    hasUpper = true;

                else if (char.IsLower(c))
                    hasLower = true;
            }

            string specialChar = "\\/~!@#$%^&*()-_+={[]};:'\"|,<.>?";
            foreach (char c in specialChar)
            {
                if (passwordTextbox.Text.Contains(c))
                {
                    hasSpecialChar = true;
                }
            }

            if(hasSpecialChar == false)
            {
                label5.Text = "Моля въведете парола, която да съдържа поне един специален символ, различен от буква или цифра.";
                return false;
            }

            if (passLength && hasDigit && hasUpper && hasLower && hasSpecialChar)
                return true;

            label5.Text = "Моля въведете парола, в която има поне една цифра, малка и голяма буква.";

            return false;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
                 
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (ValidPass() == true)
            {
                FormToDBController.AddUserToDataBase(ref controller, usernameTextbox.Text, JobPosition.Text, passwordTextbox.Text,
                    StaffcomboBox.SelectedItem.ToString().Split(' ')[0],
                    StaffcomboBox.SelectedItem.ToString().Split(' ')[1]);

                label5.Text = "Потребителят е успешно създаден!";
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            new ManagerHome(controller).Show();
            this.Hide();
        }

        private void AddUser_Load_1(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
