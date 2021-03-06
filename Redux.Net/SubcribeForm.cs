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
    public partial class SubcribeForm : Form
    {
        public SubcribeForm()
        {
            InitializeComponent();
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
