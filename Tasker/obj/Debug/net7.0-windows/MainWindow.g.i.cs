﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26DE17AC85F3FD32D5E1F9CF5649583BB0A9C787"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Tasker;


namespace Tasker {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 148 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ListsLabel;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ListsPanel;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Сlose;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MinimizeButton;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TasksLabel;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel TasksPanel;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddTaskButton;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddListButton;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClearListButton;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClearTaskButton;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RenameListButton;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditTaskButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Tasker;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 137 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Form_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ListsLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.ListsPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.Сlose = ((System.Windows.Controls.Button)(target));
            
            #line 152 "..\..\..\MainWindow.xaml"
            this.Сlose.Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MinimizeButton = ((System.Windows.Controls.Button)(target));
            
            #line 153 "..\..\..\MainWindow.xaml"
            this.MinimizeButton.Click += new System.Windows.RoutedEventHandler(this.MinimizeButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TasksLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.TasksPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.AddTaskButton = ((System.Windows.Controls.Button)(target));
            
            #line 158 "..\..\..\MainWindow.xaml"
            this.AddTaskButton.Click += new System.Windows.RoutedEventHandler(this.AddTaskButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AddListButton = ((System.Windows.Controls.Button)(target));
            
            #line 159 "..\..\..\MainWindow.xaml"
            this.AddListButton.Click += new System.Windows.RoutedEventHandler(this.AddListButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ClearListButton = ((System.Windows.Controls.Button)(target));
            
            #line 160 "..\..\..\MainWindow.xaml"
            this.ClearListButton.Click += new System.Windows.RoutedEventHandler(this.DeleteListButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ClearTaskButton = ((System.Windows.Controls.Button)(target));
            
            #line 161 "..\..\..\MainWindow.xaml"
            this.ClearTaskButton.Click += new System.Windows.RoutedEventHandler(this.DeleteTaskButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.RenameListButton = ((System.Windows.Controls.Button)(target));
            
            #line 162 "..\..\..\MainWindow.xaml"
            this.RenameListButton.Click += new System.Windows.RoutedEventHandler(this.RenameListButton_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.EditTaskButton = ((System.Windows.Controls.Button)(target));
            
            #line 163 "..\..\..\MainWindow.xaml"
            this.EditTaskButton.Click += new System.Windows.RoutedEventHandler(this.EditTaskButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

