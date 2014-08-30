using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UIImagePickerControllerDelegate protocol defines methods that your delegate object must implement to interact with the image picker interface. The methods of this protocol notify your delegate when the user either picks an image or movie, or cancels the picker operation.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIImagePickerControllerDelegate_Protocol/index.html#//apple_ref/occ/intf/UIImagePickerControllerDelegate"/>    [iOSVersion(2)]    public interface UIImagePickerControllerDelegate//: NSObjectProtocol    {        /// <summary>        /// Tells the delegate that the user picked a still image or movie.        /// </summary>        /// <param name="picker">The controller object managing the image picker interface.</param>        /// <param name="didFinishPickingMediaWithInfo">A dictionary containing the original image and the edited image, if an image was picked; or a filesystem URL for the movie, if a movie was picked. The dictionary also contains any relevant editing information. The keys for this dictionary are listed in Editing Information Keys.</param>        //[iOSVersion(3)]        //[Export("imagePickerController")]        //[Optional]        void ImagePickerController(UIImagePickerController picker, Dictionary<NSObject, AnyObject> didFinishPickingMediaWithInfo);                /// <summary>        /// Tells the delegate that the user cancelled the pick operation.        /// </summary>        /// <param name="picker">The controller object managing the image picker interface.</param>        //[iOSVersion(2)]        //[Export("imagePickerControllerDidCancel")]        //[Optional]        void ImagePickerControllerDidCancel(UIImagePickerController picker);    }}