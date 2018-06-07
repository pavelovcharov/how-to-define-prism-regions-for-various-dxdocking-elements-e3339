﻿Imports Microsoft.VisualBasic
Imports System.ComponentModel.Composition
Imports Microsoft.Practices.Prism.Regions
Imports System.Windows.Controls
Imports DevExpress.Xpf.Docking

Namespace PrismOnDXDocking.Infrastructure.Adapters
	<Export(GetType(LayoutPanelAdapter)), PartCreationPolicy(CreationPolicy.NonShared)> _
	Public Class LayoutPanelAdapter
		Inherits RegionAdapterBase(Of LayoutPanel)
		<ImportingConstructor> _
		Public Sub New(ByVal BehaviorFactory As IRegionBehaviorFactory)
			MyBase.New(BehaviorFactory)
		End Sub
		Protected Overrides Function CreateRegion() As IRegion
			Return New SingleActiveRegion()
		End Function
		Protected Overrides Sub Adapt(ByVal region As IRegion, ByVal regionTarget As LayoutPanel)
			Dim regionName As String = RegionManager.GetRegionName(regionTarget)
			If (Not String.IsNullOrEmpty(regionName)) Then
				If regionTarget IsNot Nothing AndAlso regionTarget.Content Is Nothing Then
					Dim control As New ContentControl()
					RegionManager.SetRegionName(control, regionName)
					regionTarget.Content = control
				End If
			End If
		End Sub
	End Class
End Namespace