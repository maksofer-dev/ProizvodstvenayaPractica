﻿#pragma checksum "..\..\..\View\ClientList.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F25819B516FCD169B27602342F8F827FD427A8AAAAD88304E8F1E7117DBFB2DC"
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
    /// ClientList
    /// </summary>
    public partial class ClientList : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\View\ClientList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ИС_агенства_недвижимости.ClientList clientPage;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\View\ClientList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem homeItem;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\View\ClientList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem addItem;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\View\ClientList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem deleteItem;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\View\ClientList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView clientList;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\View\ClientList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn numDogovor;
        
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
            System.Uri resourceLocater = new System.Uri("/ИС агенства недвижимости;component/view/clientlist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ClientList.xaml"
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
            this.clientPage = ((ИС_агенства_недвижимости.ClientList)(target));
            return;
            case 2:
            this.homeItem = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 35 "..\..\..\View\ClientList.xaml"
            this.homeItem.GotFocus += new System.Windows.RoutedEventHandler(this.HomeItem_GotFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.addItem = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 50 "..\..\..\View\ClientList.xaml"
            this.addItem.GotFocus += new System.Windows.RoutedEventHandler(this.addItem_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.deleteItem = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 64 "..\..\..\View\ClientList.xaml"
            this.deleteItem.GotFocus += new System.Windows.RoutedEventHandler(this.deleteItem_GotFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.clientList = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.numDogovor = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

