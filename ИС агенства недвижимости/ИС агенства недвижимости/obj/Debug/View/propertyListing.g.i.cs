﻿#pragma checksum "..\..\..\View\propertyListing.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "978FBEC1967A2D635EA605718F045E2F61585148FDF0ABED5229BA9863DFE475"
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
    /// propertyListing
    /// </summary>
    public partial class propertyListing : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\View\propertyListing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ИС_агенства_недвижимости.propertyListing realEstateListWindow;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\View\propertyListing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem homeItem;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\View\propertyListing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem rentItem;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\View\propertyListing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem sellItem;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\View\propertyListing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frame3;
        
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
            System.Uri resourceLocater = new System.Uri("/ИС агенства недвижимости;component/view/propertylisting.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\propertyListing.xaml"
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
            this.realEstateListWindow = ((ИС_агенства_недвижимости.propertyListing)(target));
            return;
            case 2:
            this.homeItem = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 27 "..\..\..\View\propertyListing.xaml"
            this.homeItem.GotFocus += new System.Windows.RoutedEventHandler(this.HomeItem_GotFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.rentItem = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 42 "..\..\..\View\propertyListing.xaml"
            this.rentItem.GotFocus += new System.Windows.RoutedEventHandler(this.rentItem_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.sellItem = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 56 "..\..\..\View\propertyListing.xaml"
            this.sellItem.GotFocus += new System.Windows.RoutedEventHandler(this.sellItem_GotFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.frame3 = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

