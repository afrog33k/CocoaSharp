using ObjectiveC;using System;using SwiftSharp.Attributes;namespace Foundation{    /// <summary>    /// A block to be called when an item provider loads an item from an extension object’s attachments property.    /// </summary>    //[iOSVersion(8)]    using NSItemProviderCompletionHandler = Action<NSSecureCoding, NSError>;            /// <summary>    /// A block to be called when an item of a specific type is being loaded from an extension object’s attachments property.    /// </summary>    //[iOSVersion(8)]
    using NSItemProviderLoadHandler = Action<Action<NSSecureCoding, NSError>, AnyClass, NSDictionary>;    //https://developer.apple.com/library/prerelease/ios/documentation/Foundation/Reference/NSItemProvider_Class/index.html#//apple_ref/occ/cl/NSItemProvider    /// <summary>    /// The NSItemProvider class defines an object that represents a high-level abstraction for data objects that can be found in an NSExtensionItem object’s attachments property, such as text, images, and URLs. An extension uses an NSItemProvider object to query the host app for available item formats, load items of specific types, and support efficient item previewing.    /// </summary>    [iOSVersion(8)]    public class NSItemProvider : NSObject    {        /// <summary>        /// Returns an item provider initialized with the contents of the specified file and an appropriate load handler.        /// </summary>        /// <param name="contentsOfURL">The URL of the file in the extension object’s attachments property.</param>        /// <returns>An initialized item provider that includes a load handler for the type identifier derived from the specified file, or nil if an error occurred.</returns>        [iOSVersion(8)]        public NSItemProvider(NSURL contentsOfURL) { }                /// <summary>        /// Returns an item provider initialized with a load handler appropriate for the specified item.        /// </summary>        /// <param name="item">An NSItemProvider object or nil.</param>        /// <param name="typeIdentifier">A string that represents the UTI of the item.</param>        /// <returns>An initialized item provider with a single load handler for the specified item.</returns>        [iOSVersion(8)]        public NSItemProvider(NSSecureCoding item, string typeIdentifier) { }                /// <summary>        /// Returns a Boolean value that indicates whether the item provider has at least one item that conforms to the specified type.        /// </summary>        /// <param name="typeIdentifier">The UTI that specifies the desired item type.</param>        /// <returns>true if the item provider has at least one item that conforms to the specified type, or false it does not.</returns>        [iOSVersion(8)]        [Export("hasItemConformingToTypeIdentifier")]        public bool HasItemConformingToTypeIdentifier(string typeIdentifier) { return false; }                /// <summary>        /// Loads the item whose type most closely matches the specified type identifier.        /// </summary>        /// <param name="typeIdentifier">A string that represents the desired UTI.</param>        /// <param name="options">A dictionary of keys and values that provide information about the item, such as the size of an image. (See NSItemProviderPreferredImageSizeKey for a key you can use.)</param>        /// <param name="completionHandler">A completion handler block that uses the form specified by NSItemProviderCompletionHandler.</param>        [iOSVersion(8)]        [Export("loadItemForTypeIdentifier")]        public void LoadItemForTypeIdentifier(string typeIdentifier, NSDictionary options, NSItemProviderCompletionHandler completionHandler) { }                /// <summary>        /// Sets the load handler block to use for the specified type identifier.        /// </summary>        /// <param name="typeIdentifier">A string that represents the desired UTI.</param>        /// <param name="loadHandler">A completion handler block that uses the form specified by NSItemProviderLoadHandler.</param>        [iOSVersion(8)]        [Export("registerItemForTypeIdentifier")]        public void RegisterItemForTypeIdentifier(string typeIdentifier, NSItemProviderLoadHandler loadHandler) { }                /// <summary>        /// Returns an array of registered type identifiers for this item provider. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("registeredTypeIdentifiers")]        public AnyObject[] RegisteredTypeIdentifiers { get; private set; }                /// <summary>        /// Loads the preview image for the specified item.        /// </summary>        /// <param name="options">A dictionary of keys and values that provide information about the item, such as the size of an image. (See NSItemProviderPreferredImageSizeKey for a key you can use.)</param>        /// <param name="completionHandler">A completion handler block that uses the form specified by NSItemProviderCompletionHandler.</param>        [iOSVersion(8)]        [Export("loadPreviewImageWithOptions")]        public void LoadPreviewImageWithOptions(NSDictionary options, NSItemProviderCompletionHandler completionHandler) { }                /// <summary>        /// The custom preview image handler block to use with this item provider.        /// </summary>        [iOSVersion(8)]        [Export("previewImageHandler")]        public NSItemProviderLoadHandler PreviewImageHandler { get; set; }                /// <summary>        /// A key used in the options dictionary to specify information about the item.        /// </summary>        [Export("NSItemProviderPreferredImageSizeKey")]        public string NSItemProviderPreferredImageSizeKey { get; private set; }                /// <summary>        /// Keys used in property list items received from or sent to JavaScript code.        /// </summary>                /// <summary>        /// A key whose value is an item of type kUTTypePropertyList. The item contains an NSDictionary that contains the object returned by the JavaScript code to its completion function.        /// </summary>        [iOSVersion(8)]        public string NSExtensionJavaScriptPreprocessingResultsKey { get; private set; }                /// <summary>        /// A key whose value is an item of type kUTTypePropertyList. The item contains an NSDictionary that contains the arguments to be passed to a JavaScript finalize method.        /// </summary>        [iOSVersion(8)]        public string NSExtensionJavaScriptFinalizeArgumentKey { get; private set; }    }}