﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.CodeAnalysis.IL.Sdk {
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
    internal class SdkResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SdkResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.CodeAnalysis.IL.Sdk.SdkResources", typeof(SdkResources).Assembly);
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
        ///   Looks up a localized string similar to A binary context object was re-initialized with a new file path..
        /// </summary>
        internal static string IllegalContextReuse {
            get {
                return ResourceManager.GetString("IllegalContextReuse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to an exception occurred attempting to load its pdb.
        /// </summary>
        internal static string MetadataCondition_CouldNotLoadPdb {
            get {
                return ResourceManager.GetString("MetadataCondition_CouldNotLoadPdb", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to image was compiled with a toolset version ({0}) that is not sufficiently recent ({1} or newer) to provide relevant settings.
        /// </summary>
        internal static string MetadataCondition_ImageCompiledWithOutdatedTools {
            get {
                return ResourceManager.GetString("MetadataCondition_ImageCompiledWithOutdatedTools", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to image does not have an entry point.
        /// </summary>
        internal static string MetadataCondition_ImageHasNoEntryPoint {
            get {
                return ResourceManager.GetString("MetadataCondition_ImageHasNoEntryPoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to image is a 64-bit binary.
        /// </summary>
        internal static string MetadataCondition_ImageIs64BitBinary {
            get {
                return ResourceManager.GetString("MetadataCondition_ImageIs64BitBinary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to image is a boot binary.
        /// </summary>
        internal static string MetadataCondition_ImageIsBootBinary {
            get {
                return ResourceManager.GetString("MetadataCondition_ImageIsBootBinary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to image is a binary built by the .NET native toolset.
        /// </summary>
        internal static string MetadataCondition_ImageIsDotNetNativeBinary {
            get {
                return ResourceManager.GetString("MetadataCondition_ImageIsDotNetNativeBinary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to image is an IL-only managed assembly.
        /// </summary>
        internal static string MetadataCondition_ImageIsILOnlyManagedAssembly {
            get {
                return ResourceManager.GetString("MetadataCondition_ImageIsILOnlyManagedAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to image is not 64-bit (the only architecture that enables CFG for kernel mode binaries).
        /// </summary>
        internal static string MetadataCondition_ImageIsKernelModeAndNot64Bit_CfgUnsupported {
            get {
                return ResourceManager.GetString("MetadataCondition_ImageIsKernelModeAndNot64Bit_CfgUnsupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to image is a kernel mode binary.
        /// </summary>
        internal static string MetadataCondition_ImageIsKernelModeBinary {
            get {
                return ResourceManager.GetString("MetadataCondition_ImageIsKernelModeBinary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to image is a managed interop assembly.
        /// </summary>
        internal static string MetadataCondition_ImageIsManagedInteropAssembly {
            get {
                return ResourceManager.GetString("MetadataCondition_ImageIsManagedInteropAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to image is a managed resource-only assembly.
        /// </summary>
        internal static string MetadataCondition_ImageIsManagedResourceOnlyAssembly {
            get {
                return ResourceManager.GetString("MetadataCondition_ImageIsManagedResourceOnlyAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to image is a mixed mode binary.
        /// </summary>
        internal static string MetadataCondition_ImageIsMixedModeBinary {
            get {
                return ResourceManager.GetString("MetadataCondition_ImageIsMixedModeBinary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to image is not a 32-bit binary.
        /// </summary>
        internal static string MetadataCondition_ImageIsNot32BitBinary {
            get {
                return ResourceManager.GetString("MetadataCondition_ImageIsNot32BitBinary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to image is not a 64-bit binary.
        /// </summary>
        internal static string MetadataCondition_ImageIsNot64BitBinary {
            get {
                return ResourceManager.GetString("MetadataCondition_ImageIsNot64BitBinary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to image is not signed .
        /// </summary>
        internal static string MetadataCondition_ImageIsNotSigned {
            get {
                return ResourceManager.GetString("MetadataCondition_ImageIsNotSigned", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to image is a pre-version 7 Windows CE binary.
        /// </summary>
        internal static string MetadataCondition_ImageIsPreVersion7WindowsCEBinary {
            get {
                return ResourceManager.GetString("MetadataCondition_ImageIsPreVersion7WindowsCEBinary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to image is a resource-only binary.
        /// </summary>
        internal static string MetadataCondition_ImageIsResourceOnlyBinary {
            get {
                return ResourceManager.GetString("MetadataCondition_ImageIsResourceOnlyBinary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to image is an xbox binary.
        /// </summary>
        internal static string MetadataCondition_ImageIsXboxBinary {
            get {
                return ResourceManager.GetString("MetadataCondition_ImageIsXboxBinary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Check &apos;{0}&apos; was disabled for this run as the analysis was not configured with required policy ({1}). To resolve this, configure and provide a policy file on the BinSkim command-line using the --policy argument (recommended), or pass --defaultPolicy to invoke built-in settings. Invoke the BinSkim.exe &apos;export&apos; command to produce an initial policy file that can be edited if required and passed back into the tool..
        /// </summary>
        internal static string RuleWasDisabledDueToMissingPolicy {
            get {
                return ResourceManager.GetString("RuleWasDisabledDueToMissingPolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; was not analyzed as it does not appear to be a valid portable executable..
        /// </summary>
        internal static string TargetNotAnalyzed_NotAPortableExecutable {
            get {
                return ResourceManager.GetString("TargetNotAnalyzed_NotAPortableExecutable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; was not evaluated for check &apos;{1}&apos; as the analysis is not relevant based on observed binary metadata: {2}..
        /// </summary>
        internal static string TargetNotAnalyzed_NotApplicable {
            get {
                return ResourceManager.GetString("TargetNotAnalyzed_NotApplicable", resourceCulture);
            }
        }
    }
}
