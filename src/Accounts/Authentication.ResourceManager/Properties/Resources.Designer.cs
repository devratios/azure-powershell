﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Common.Authentication.ResourceManager.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.Common.Authentication.ResourceManager.Properties.Resourc" +
                            "es", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to No certificate was found in the certificate store with thumbprint {0}.
        /// </summary>
        internal static string CertificateNotFoundInStore {
            get {
                return ResourceManager.GetString("CertificateNotFoundInStore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not acquire access to file &apos;{0}&apos; please try again in a few minutes..
        /// </summary>
        internal static string FileLockFailure {
            get {
                return ResourceManager.GetString("FileLockFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Illegal characters in path..
        /// </summary>
        internal static string IllegalPath {
            get {
                return ResourceManager.GetString("IllegalPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid certificate format. Publish settings may be corrupted. Use Get-AzurePublishSettingsFile to download updated settings.
        /// </summary>
        internal static string InvalidCertificate {
            get {
                return ResourceManager.GetString("InvalidCertificate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;{0}&quot; is an invalid DNS name for {1}.
        /// </summary>
        internal static string InvalidDnsName {
            get {
                return ResourceManager.GetString("InvalidDnsName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A valid file path must be provided..
        /// </summary>
        internal static string InvalidFilePath {
            get {
                return ResourceManager.GetString("InvalidFilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please connect to internet before executing this cmdlet.
        /// </summary>
        internal static string NoInternetConnection {
            get {
                return ResourceManager.GetString("NoInternetConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A valid implementation of IDataStore must be provided..
        /// </summary>
        internal static string NullDataStore {
            get {
                return ResourceManager.GetString("NullDataStore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempted to read from the Azure PowerShell context after it was disposed.  Please reload the module and try this operation again..
        /// </summary>
        internal static string ProfileLockReadDisposed {
            get {
                return ResourceManager.GetString("ProfileLockReadDisposed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempted to read from the Azure PowerShell context while it was in use.  Please reload the module and try this operation again..
        /// </summary>
        internal static string ProfileLockReadRecursion {
            get {
                return ResourceManager.GetString("ProfileLockReadRecursion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempted to write to the Azure PowerShell context after it was disposed.  Please reload the module and try this operation again..
        /// </summary>
        internal static string ProfileLockWriteDisposed {
            get {
                return ResourceManager.GetString("ProfileLockWriteDisposed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempted to write to the Azure PowerShell context while reading from the context Please reload the module and try this operation again..
        /// </summary>
        internal static string ProfileLockWriteRecursion {
            get {
                return ResourceManager.GetString("ProfileLockWriteRecursion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Azure PowerShell context has not been properly initialized.  Please import the module and try again..
        /// </summary>
        internal static string ProfileNotInitialized {
            get {
                return ResourceManager.GetString("ProfileNotInitialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;whr={0}.
        /// </summary>
        internal static string PublishSettingsFileRealmFormat {
            get {
                return ResourceManager.GetString("PublishSettingsFileRealmFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided service name {0} already exists, please pick another name.
        /// </summary>
        internal static string ServiceNameExists {
            get {
                return ResourceManager.GetString("ServiceNameExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempted to read from the Azure PowerShell Session after it was disposed.  Please reload the module and try this operation again..
        /// </summary>
        internal static string SessionLockReadDisposed {
            get {
                return ResourceManager.GetString("SessionLockReadDisposed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempted to read from the Azure PowerShell Session while it was in use.  Please reload the module and try this operation again..
        /// </summary>
        internal static string SessionLockReadRecursion {
            get {
                return ResourceManager.GetString("SessionLockReadRecursion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempted to write to the Azure PowerShell Session after it was disposed.  Please reload the module and try this operation again..
        /// </summary>
        internal static string SessionLockWriteDisposed {
            get {
                return ResourceManager.GetString("SessionLockWriteDisposed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempted to write to the Azure PowerShell Session while reading from the session.  Please reload the module and try this operation again..
        /// </summary>
        internal static string SessionLockWriteRecursion {
            get {
                return ResourceManager.GetString("SessionLockWriteRecursion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Azure PowerShell session has not been properly initialized.  Please import the module and try again..
        /// </summary>
        internal static string SessionNotInitialized {
            get {
                return ResourceManager.GetString("SessionNotInitialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot read the file at &apos;{0}&apos;. Please ensure that you have appropriate access to this file and try executing this cmdlet again in a few minutes..
        /// </summary>
        internal static string UnreadableStream {
            get {
                return ResourceManager.GetString("UnreadableStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot write to the file at &apos;{0}&apos;. Please ensure that you have appropriate access to this file and try executing this cmdlet again in a few minutes..
        /// </summary>
        internal static string UnwritableStream {
            get {
                return ResourceManager.GetString("UnwritableStream", resourceCulture);
            }
        }
    }
}
