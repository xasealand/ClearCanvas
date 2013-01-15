﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.Ris.Client.Workflow.Extended {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class OrderNoteboxFolderSystemSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static OrderNoteboxFolderSystemSettings defaultInstance = ((OrderNoteboxFolderSystemSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new OrderNoteboxFolderSystemSettings())));
        
        public static OrderNoteboxFolderSystemSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Stores which group inbox folders are visible for each user
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Stores which group inbox folders are visible for each user")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string GroupFoldersXml {
            get {
                return ((string)(this["GroupFoldersXml"]));
            }
            set {
                this["GroupFoldersXml"] = value;
            }
        }
        
        /// <summary>
        /// Folder auto-refresh interval (milliseconds)
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Folder auto-refresh interval (milliseconds)")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("120000")]
        public int RefreshTime {
            get {
                return ((int)(this["RefreshTime"]));
            }
        }
        
        /// <summary>
        /// For Order Notebox queries, controls number of order-note items per page
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("For Order Notebox queries, controls number of order-note items per page")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int ItemsPerPage {
            get {
                return ((int)(this["ItemsPerPage"]));
            }
        }
    }
}