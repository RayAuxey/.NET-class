﻿#ExternalChecksum("C:\Users\STUDENT.Admin-PC.001\Desktop\WPA\ListBox2\ListBox2\MainPage.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","CE10A9B43CD010FD6992819F35AC6395")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Microsoft.Phone.Controls
Imports System
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Automation.Peers
Imports System.Windows.Automation.Provider
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Interop
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Imaging
Imports System.Windows.Resources
Imports System.Windows.Shapes
Imports System.Windows.Threading



<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class MainPage
    Inherits Microsoft.Phone.Controls.PhoneApplicationPage
    
    Friend WithEvents LayoutRoot As System.Windows.Controls.Grid
    
    Friend WithEvents TitlePanel As System.Windows.Controls.StackPanel
    
    Friend WithEvents ApplicationTitle As System.Windows.Controls.TextBlock
    
    Friend WithEvents PageTitle As System.Windows.Controls.TextBlock
    
    Friend WithEvents ContentPanel As System.Windows.Controls.Grid
    
    Friend WithEvents lstCourses As System.Windows.Controls.ListBox
    
    Friend WithEvents lstRegistered As System.Windows.Controls.ListBox
    
    Friend WithEvents btnRegister As System.Windows.Controls.Button
    
    Friend WithEvents btnDeregister As System.Windows.Controls.Button
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub InitializeComponent()
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        System.Windows.Application.LoadComponent(Me, New System.Uri("/ListBox2;component/MainPage.xaml", System.UriKind.Relative))
        Me.LayoutRoot = CType(Me.FindName("LayoutRoot"),System.Windows.Controls.Grid)
        Me.TitlePanel = CType(Me.FindName("TitlePanel"),System.Windows.Controls.StackPanel)
        Me.ApplicationTitle = CType(Me.FindName("ApplicationTitle"),System.Windows.Controls.TextBlock)
        Me.PageTitle = CType(Me.FindName("PageTitle"),System.Windows.Controls.TextBlock)
        Me.ContentPanel = CType(Me.FindName("ContentPanel"),System.Windows.Controls.Grid)
        Me.lstCourses = CType(Me.FindName("lstCourses"),System.Windows.Controls.ListBox)
        Me.lstRegistered = CType(Me.FindName("lstRegistered"),System.Windows.Controls.ListBox)
        Me.btnRegister = CType(Me.FindName("btnRegister"),System.Windows.Controls.Button)
        Me.btnDeregister = CType(Me.FindName("btnDeregister"),System.Windows.Controls.Button)
    End Sub
End Class
