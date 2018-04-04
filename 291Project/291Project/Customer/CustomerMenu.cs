﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _291Project.Employee
{
    public partial class CustomerMenu : Form
    {
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void CreateOrder_Click(object sender, EventArgs e)
        {
            CreateOrder createOrder = new CreateOrder();
            createOrder.Show();
        }

        private void MovieSuggestionButton_Click(object sender, EventArgs e)
        {
            Customer.CustomerMovieSuggestions customerMovieSuggestions = new Customer.CustomerMovieSuggestions();
            customerMovieSuggestions.Show();
        }

        private void edit_info_Click(object sender, EventArgs e)
        {
            Customer.InfoEdit info = new Customer.InfoEdit();
            info.Show();
        }

        private void view_movies_Click(object sender, EventArgs e)
        {
            CustomerMovie movie = new CustomerMovie();
            movie.Show();
        }
    }
}
