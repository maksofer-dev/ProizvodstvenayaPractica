﻿#pragma checksum "..\..\..\..\View\MainView\BarCodeWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FD027D6D3073D3AA3D9EAD7AA480F92E3113D4A5EB10F9130489329D66298554"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using ИС_агенства_недвижимости.View.MainView;


namespace ИС_агенства_недвижимости.View.MainView {
    
    
    /// <summary>
    /// BarCodeWindow
    /// </summary>
    public partial class BarCodeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\View\MainView\BarCodeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button closeButt;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\View\MainView\BarCodeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image barCodeIMG;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\View\MainView\BarCodeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label barCodeLBL;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\View\MainView\BarCodeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveBarCodeBN;
        
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
            System.Uri resourceLocater = new System.Uri("/ИС агенства недвижимости;component/view/mainview/barcodewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\MainView\BarCodeWindow.xaml"
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
            this.closeButt = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\View\MainView\BarCodeWindow.xaml"
            this.closeButt.Click += new System.Windows.RoutedEventHandler(this.closeButt_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.barCodeIMG = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.barCodeLBL = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.saveBarCodeBN = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\..\View\MainView\BarCodeWindow.xaml"
            this.saveBarCodeBN.Click += new System.Windows.RoutedEventHandler(this.saveBarCodeBN_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

