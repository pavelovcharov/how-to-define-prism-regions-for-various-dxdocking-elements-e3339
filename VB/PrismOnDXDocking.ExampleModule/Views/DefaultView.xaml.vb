﻿Imports Microsoft.VisualBasic
Imports System.ComponentModel.Composition
Imports System.Windows.Controls
Imports PrismOnDXDocking.Infrastructure

Namespace PrismOnDXDocking.ExampleModule.Views
	<PartCreationPolicy(CreationPolicy.NonShared), Export> _
	Partial Public Class DefaultView
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
