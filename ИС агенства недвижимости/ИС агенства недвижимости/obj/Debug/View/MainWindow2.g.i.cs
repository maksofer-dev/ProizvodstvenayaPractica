﻿#pragma checksum "..\..\..\View\MainWindow2.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "67561ECABB9C9464FCFB65ECA26AB9B07FCCE8BC14C37B5C77D37F566D43ECC9"
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
using ИС_агенства_недвижимости;


namespace ИС_агенства_недвижимости {
    
    
    /// <summary>
    /// MainWindow2
    /// </summary>
    public partial class MainWindow2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\View\MainWindow2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ИС_агенства_недвижимости.MainWindow2 mainWindow2;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\View\MainWindow2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frame2;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\View\MainWindow2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border mainWindowBorder;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\View\MainWindow2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button closeButton;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\View\MainWindow2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label mainPageLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/ИС агенства недвижимости;component/view/mainwindow2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\MainWindow2.xaml"
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
            this.mainWindow2 = ((ИС_агенства_недвижимости.MainWindow2)(target));
            return;
            case 2:
            this.frame2 = ((System.Windows.Controls.Frame)(target));
            return;
            case 3:
            this.mainWindowBorder = ((System.Windows.Controls.Border)(target));
            
            #line 12 "..\..\..\View\MainWindow2.xaml"
            this.mainWindowBorder.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MainWindowBorder_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.closeButton = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\View\MainWindow2.xaml"
            this.closeButton.Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.mainPageLabel = ((System.Windows.Controls.Label)(target));
            
            #line 42 "..\..\..\View\MainWindow2.xaml"
            this.mainPageLabel.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.mainPageLabel_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

