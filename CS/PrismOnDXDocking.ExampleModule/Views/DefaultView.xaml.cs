﻿using Microsoft.VisualBasic;
using System.ComponentModel.Composition;
using System.Windows.Controls;
using PrismOnDXDocking.Infrastructure;
using System;

namespace PrismOnDXDocking.ExampleModule.Views {
    [PartCreationPolicy(CreationPolicy.NonShared), Export]
    public partial class DefaultView : UserControl, IPanelInfo {
        public DefaultView() {
            InitializeComponent();
        }

        public string PanelCaption { get { return "Default View"; } }
    }
}