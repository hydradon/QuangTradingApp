﻿#pragma checksum "..\..\TradeWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0AE6B77C3B1509790AE7D2BE801FA5C4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using QuangsTradingApp;
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


namespace QuangsTradingApp {
    
    
    /// <summary>
    /// TradeWindow
    /// </summary>
    public partial class TradeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\TradeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NewStockTextBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\TradeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NewStockNumber;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\TradeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NewMinPrice;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\TradeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NewMaxPrice;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\TradeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Buy;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\TradeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Sell;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\TradeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\TradeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label NumTradeLabel;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\TradeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NumbTradeTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/QuangsTradingApp;component/tradewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TradeWindow.xaml"
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
            this.NewStockTextBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.NewStockNumber = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.NewMinPrice = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.NewMaxPrice = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Buy = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\TradeWindow.xaml"
            this.Buy.Click += new System.Windows.RoutedEventHandler(this.BuySell_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Sell = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\TradeWindow.xaml"
            this.Sell.Click += new System.Windows.RoutedEventHandler(this.BuySell_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CancelButton = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.NumTradeLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.NumbTradeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

