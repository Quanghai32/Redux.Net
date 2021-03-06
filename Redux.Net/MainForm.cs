﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redux.Net
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SubcribeForm sForm = new SubcribeForm();
            sForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RootStore.CounterStore.Subscribe(counter => labelCounter.Text = counter.ToString());
        }

        private void buttonIncrement_Click(object sender, EventArgs e)
        {
            RootStore.CounterStore.Dispatch(new IncrementAction());
        }

        private void buttonDecrement_Click(object sender, EventArgs e)
        {
            RootStore.CounterStore.Dispatch(new DecrementAction());
        }
    }
}
