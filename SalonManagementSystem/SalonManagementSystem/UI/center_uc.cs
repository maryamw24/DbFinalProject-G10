﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonManagementSystem.UI
{
    public partial class center_uc : UserControl
    {
        public center_uc()
        {
            InitializeComponent();
        }

        public TableLayoutPanel OuterTablePanel
        {
            get { return outer_tablepanel; }
        }
        public Panel DropdownPanel
        {
            get { return dropdown_panel; }
        }
    }
}
