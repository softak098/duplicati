﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Duplicati.Library.Main.Strings {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class FhOptions {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal FhOptions() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Duplicati.Library.Main.Strings.FhOptions", typeof(FhOptions).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The blocksize determines how files are fragmented. Choosing a large value will cause a larger overhead on file changes, choosing a small value will cause a large overhead on storage of file lists. Note that the value cannot be changed after remote files are created..
        /// </summary>
        internal static string FhblocksizeLong {
            get {
                return ResourceManager.GetString("FhblocksizeLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Blocksize used in hashing.
        /// </summary>
        internal static string FhblocksizeShort {
            get {
                return ResourceManager.GetString("FhblocksizeShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path to the file containing the local cache of the remote file database.
        /// </summary>
        internal static string FhdbpathLong {
            get {
                return ResourceManager.GetString("FhdbpathLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path to the local state database.
        /// </summary>
        internal static string FhdbpathShort {
            get {
                return ResourceManager.GetString("FhdbpathShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stores empty metadata, such as file timestamps and attributes. This decreases the required storage space as well as the processing time..
        /// </summary>
        internal static string FhnometadataLong {
            get {
                return ResourceManager.GetString("FhnometadataLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disable storing file metadata.
        /// </summary>
        internal static string FhnometadataShort {
            get {
                return ResourceManager.GetString("FhnometadataShort", resourceCulture);
            }
        }
    }
}
