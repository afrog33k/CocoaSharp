using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace UIKit{    /// <summary>    /// The UIDocumentPickerExtensionViewController class is the principal class for the Document Picker View Controller extension. When creating a Document Picker extension, you must subclass UIDocumentPickerExtensionViewController to provide the document picker’s user interface. Your subclass presents a list of available documents and destinations to the user. When the user makes a selection, you trigger the file transfer and pass the selected URL back to the host app.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIDocumentPickerExtensionViewController_Class/index.html#//apple_ref/occ/cl/UIDocumentPickerExtensionViewController"/>    [iOSVersion(8)]    public class UIDocumentPickerExtensionViewController : UIViewController//, AnyObject, NSCoding, NSExtensionRequestHandling, NSObjectProtocol, UIAppearanceContainer, UIContentContainer, UIStateRestoring, UITraitEnvironment    {        /// <summary>        /// Dismisses the document picker and triggers the file transfer.        /// </summary>        /// <param name="url">The URL that the extension returns to the host app.</param>        [iOSVersion(8)]        [Export("dismissGrantingAccessToURL")]        public void DismissGrantingAccessToURL(NSURL url) {  }                /// <summary>        /// Performs any custom configuration of the document picker view controller.        /// </summary>        /// <param name="mode">The type of file-transfer operation that the document picker performs. For a list of valid modes, see Document Picker Modes in UIDocumentPickerViewController Class Reference.</param>        [iOSVersion(8)]        [Export("prepareForPresentationInMode")]        public void PrepareForPresentationInMode(UIDocumentPickerMode mode) {  }                /// <summary>        /// The document picker’s file-transfer operation. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("documentPickerMode")]        public UIDocumentPickerMode DocumentPickerMode { get; private set; }                /// <summary>        /// The root URL for documents provided by the corresponding File Provider extension. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("documentStorageURL")]        public NSURL DocumentStorageURL { get; private set; }                /// <summary>        /// The URL of the file to be exported. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("originalURL")]        public NSURL OriginalURL { get; private set; }                /// <summary>        /// An identifier shared by this Document Picker extension and its corresponding File Provider extension. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("providerIdentifier")]        public string ProviderIdentifier { get; private set; }                /// <summary>        /// An array of valid uniform type identifiers. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("validTypes")]        public AnyObject[] ValidTypes { get; private set; }    }}