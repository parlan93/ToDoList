﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ToDoList.Models;

namespace ToDoList.Views.Pages
{
    /// <summary>
    /// Interaction logic for Categories.xaml
    /// </summary>
    public partial class CategoriesView : Page
    {
        //DataModel db = new DataModel();
        //public static DataGrid Grid;

        public CategoriesView()
        {
            InitializeComponent();

            Load();
        }

        private void Load()
        {
            using (var db = new DataModel())
            {
                tmpGrid.ItemsSource = db.Categories.ToList();
            }
        }
    }
}
