﻿#pragma checksum "..\..\Reg.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4FF6E576055B2740C57227F677DDFAF8702EAD0B7ABD18ED25A29AAA4965F392"
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
using ИС_агенства_недвижимости;


namespace ИС_агенства_недвижимости {
    
    
    /// <summary>
    /// Reg
    /// </summary>
    public partial class Reg : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passBox1;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox logBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passBox2;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button accButt;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button prevButt;
        
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
            System.Uri resourceLocater = new System.Uri("/ИС агенства недвижимости;component/reg.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Reg.xaml"
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
            this.passBox1 = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 19 "..\..\Reg.xaml"
            this.passBox1.PasswordChanged += new System.Windows.RoutedEventHandler(this.PassBox1_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.logBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\Reg.xaml"
            this.logBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.LogBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.textBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.passBox2 = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 30 "..\..\Reg.xaml"
            this.passBox2.PasswordChanged += new System.Windows.RoutedEventHandler(this.PassBox2_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.accButt = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\Reg.xaml"
            this.accButt.Click += new System.Windows.RoutedEventHandler(this.AccButt_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.prevButt = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\Reg.xaml"
            this.prevButt.Click += new System.Windows.RoutedEventHandler(this.PrevButt_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

