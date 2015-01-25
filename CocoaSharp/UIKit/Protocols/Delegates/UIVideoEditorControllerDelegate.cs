using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UIVideoEditorControllerDelegate protocol defines methods that your delegate object must implement to respond to the video editor. The methods of this protocol notify your delegate when the system has saved an edited movie or the user has cancelled editing to discard any changes. There is also a method for responding to errors encountered by the video editor.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIVideoEditorControllerDelegate_ProtocolReference/index.html#//apple_ref/occ/intf/UIVideoEditorControllerDelegate"/>    [iOSVersion(3.1)]    [Export("")]    public interface UIVideoEditorControllerDelegate//: NSObjectProtocol    {        /// <summary>        /// Called when the system has finished saving an edited movie. (required)        /// </summary>        /// <param name="editor">The video editor that has finished editing and saving a movie.</param>        /// <param name="didSaveEditedVideoToPath">The filesystem path to the edited movie.</param>        //[iOSVersion(3.1)]        //[Export("videoEditorController")]        //[InheritOptional]        //void VideoEditorController(UIVideoEditorController editor, string didSaveEditedVideoToPath);                /// <summary>        /// Called when the user has cancelled a movie editing operation. (required)        /// </summary>        /// <param name="editor">The video editor that the user cancelled, not wanting to save changes.</param>        //[iOSVersion(3.1)]        //[Export("videoEditorControllerDidCancel")]        //[InheritOptional]        //void VideoEditorControllerDidCancel(UIVideoEditorController editor);                /// <summary>        /// Called when the video editor is unable to load or save a movie. (required)        /// </summary>        /// <param name="editor">The video editor that was unable to load or save a movie.</param>        /// <param name="didFailWithError">The loading or saving error.</param>        //[iOSVersion(3.1)]        //[Export("videoEditorController")]        //[InheritOptional]        //void VideoEditorController(UIVideoEditorController editor, NSError didFailWithError);    }}