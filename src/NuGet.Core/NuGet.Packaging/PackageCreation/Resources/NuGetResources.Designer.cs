﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGet.Packaging.PackageCreation.Resources {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class NuGetResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal NuGetResources() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGet.Packaging.PackageCreation.Resources.NuGetResources", typeof(NuGetResources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
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
        ///    Looks up a localized string similar to Cannot create a package that has no dependencies nor content..
        /// </summary>
        internal static string CannotCreateEmptyPackage {
            get {
                return ResourceManager.GetString("CannotCreateEmptyPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Dependency &apos;{0}&apos; has an invalid version..
        /// </summary>
        internal static string DependencyHasInvalidVersion {
            get {
                return ResourceManager.GetString("DependencyHasInvalidVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &apos;{0}&apos; already has a dependency defined for &apos;{1}&apos;..
        /// </summary>
        internal static string DuplicateDependenciesDefined {
            get {
                return ResourceManager.GetString("DuplicateDependenciesDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The schema version of &apos;{0}&apos; is incompatible with version {1} of NuGet. Please upgrade NuGet to the latest version from http://go.microsoft.com/fwlink/?LinkId=213942..
        /// </summary>
        internal static string IncompatibleSchema {
            get {
                return ResourceManager.GetString("IncompatibleSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The package ID &apos;{0}&apos; contains invalid characters. Examples of valid package IDs include &apos;MyPackage&apos; and &apos;MyPackage.Sample&apos;..
        /// </summary>
        internal static string InvalidPackageId {
            get {
                return ResourceManager.GetString("InvalidPackageId", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;dependencies&gt; element must not contain both &lt;group&gt; and &lt;dependency&gt; child elements..
        /// </summary>
        internal static string Manifest_DependenciesHasMixedElements {
            get {
                return ResourceManager.GetString("Manifest_DependenciesHasMixedElements", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Exclude path &apos;{0}&apos; contains invalid characters..
        /// </summary>
        internal static string Manifest_ExcludeContainsInvalidCharacters {
            get {
                return ResourceManager.GetString("Manifest_ExcludeContainsInvalidCharacters", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Id must not exceed 100 characters..
        /// </summary>
        internal static string Manifest_IdMaxLengthExceeded {
            get {
                return ResourceManager.GetString("Manifest_IdMaxLengthExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The &apos;minClientVersion&apos; attribute in the package manifest has invalid value. It must be a valid version string..
        /// </summary>
        internal static string Manifest_InvalidMinClientVersion {
            get {
                return ResourceManager.GetString("Manifest_InvalidMinClientVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to A stable release of a package should not have on a prerelease dependency. Either modify the version spec of dependency &quot;{0}&quot; or update the version field..
        /// </summary>
        internal static string Manifest_InvalidPrereleaseDependency {
            get {
                return ResourceManager.GetString("Manifest_InvalidPrereleaseDependency", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Invalid assembly reference &apos;{0}&apos;. Ensure that a file named &apos;{0}&apos; exists in the lib directory..
        /// </summary>
        internal static string Manifest_InvalidReference {
            get {
                return ResourceManager.GetString("Manifest_InvalidReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Assembly reference &apos;{0}&apos; contains invalid characters..
        /// </summary>
        internal static string Manifest_InvalidReferenceFile {
            get {
                return ResourceManager.GetString("Manifest_InvalidReferenceFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;references&gt; element must not contain both &lt;group&gt; and &lt;reference&gt; child elements..
        /// </summary>
        internal static string Manifest_ReferencesHasMixedElements {
            get {
                return ResourceManager.GetString("Manifest_ReferencesHasMixedElements", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The element package\metadata\references\group must contain at least one &lt;reference&gt; child element..
        /// </summary>
        internal static string Manifest_ReferencesIsEmpty {
            get {
                return ResourceManager.GetString("Manifest_ReferencesIsEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The required element &apos;{0}&apos; is missing from the manifest..
        /// </summary>
        internal static string Manifest_RequiredElementMissing {
            get {
                return ResourceManager.GetString("Manifest_RequiredElementMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {0} is required..
        /// </summary>
        internal static string Manifest_RequiredMetadataMissing {
            get {
                return ResourceManager.GetString("Manifest_RequiredMetadataMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Enabling license acceptance requires a license url..
        /// </summary>
        internal static string Manifest_RequireLicenseAcceptanceRequiresLicenseUrl {
            get {
                return ResourceManager.GetString("Manifest_RequireLicenseAcceptanceRequiresLicenseUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Source path &apos;{0}&apos; contains invalid characters..
        /// </summary>
        internal static string Manifest_SourceContainsInvalidCharacters {
            get {
                return ResourceManager.GetString("Manifest_SourceContainsInvalidCharacters", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Target path &apos;{0}&apos; contains invalid characters..
        /// </summary>
        internal static string Manifest_TargetContainsInvalidCharacters {
            get {
                return ResourceManager.GetString("Manifest_TargetContainsInvalidCharacters", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {0} cannot be empty..
        /// </summary>
        internal static string Manifest_UriCannotBeEmpty {
            get {
                return ResourceManager.GetString("Manifest_UriCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to File not found: &apos;{0}&apos;..
        /// </summary>
        internal static string PackageAuthoring_FileNotFound {
            get {
                return ResourceManager.GetString("PackageAuthoring_FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Versions using SemVer 2.0.0 are not supported: {0}..
        /// </summary>
        internal static string SemVer2VersionsNotSupported {
            get {
                return ResourceManager.GetString("SemVer2VersionsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The special version part cannot exceed 20 characters..
        /// </summary>
        internal static string SemVerSpecialVersionTooLong {
            get {
                return ResourceManager.GetString("SemVerSpecialVersionTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Unknown schema version &apos;{0}&apos;..
        /// </summary>
        internal static string UnknownSchemaVersion {
            get {
                return ResourceManager.GetString("UnknownSchemaVersion", resourceCulture);
            }
        }
    }
}
