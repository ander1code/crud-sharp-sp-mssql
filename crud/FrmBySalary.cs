﻿using libCRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRUD_Sharp
{
    public partial class FrmBySalary : Form
    {
        public FrmBySalary(List<PhysicalPerson> list)
        {
            InitializeComponent();
            this.PhysicalPersonBindingSource.DataSource = list;
        }

        private void FrmBySalary_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
