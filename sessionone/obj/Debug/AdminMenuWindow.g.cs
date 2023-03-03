﻿#pragma checksum "..\..\AdminMenuWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1F225B403EE88F20D34773E21B8598046D9883EB007FECE14105DC4CA3D93C0C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using exam.assets;


namespace exam.assets {
    
    
    /// <summary>
    /// AdminMenuWindow
    /// </summary>
    public partial class AdminMenuWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\AdminMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addUserButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AdminMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AdminMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxOffices;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AdminMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid usersGrid;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\AdminMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button changeButton;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\AdminMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button banButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/exam;component/adminmenuwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminMenuWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.addUserButton = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\AdminMenuWindow.xaml"
            this.addUserButton.Click += new System.Windows.RoutedEventHandler(this.addUserButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.exitButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\AdminMenuWindow.xaml"
            this.exitButton.Click += new System.Windows.RoutedEventHandler(this.exitButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.comboBoxOffices = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\AdminMenuWindow.xaml"
            this.comboBoxOffices.Loaded += new System.Windows.RoutedEventHandler(this.comboBoxOffices_Loaded);
            
            #line default
            #line hidden
            
            #line 29 "..\..\AdminMenuWindow.xaml"
            this.comboBoxOffices.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBoxOffices_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.usersGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 40 "..\..\AdminMenuWindow.xaml"
            this.usersGrid.Loaded += new System.Windows.RoutedEventHandler(this.usersGrid_Loaded);
            
            #line default
            #line hidden
            return;
            case 5:
            this.changeButton = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\AdminMenuWindow.xaml"
            this.changeButton.Click += new System.Windows.RoutedEventHandler(this.Btn_ChangeRole);
            
            #line default
            #line hidden
            return;
            case 6:
            this.banButton = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\AdminMenuWindow.xaml"
            this.banButton.Click += new System.Windows.RoutedEventHandler(this.Btn_EbableDisableLogin);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
