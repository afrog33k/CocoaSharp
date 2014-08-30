using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UIPopoverControllerDelegate protocol defines the methods you can implement for the delegate of a UIPopoverController object. Popover controllers notify their delegate whenever user interactions would cause the dismissal of the popover and, in some cases, give the user a chance to prevent that dismissal.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIPopoverControllerDelegate_protocol/index.html#//apple_ref/occ/intf/UIPopoverControllerDelegate"/>    [iOSVersion(3.2)]    public interface UIPopoverControllerDelegate//: NSObjectProtocol    {        /// <summary>        /// Tells the delegate that the popover controller needs to change the popover’s location in its view.        /// </summary>        /// <param name="popoverController">The popover controller changing the position of its content.</param>        /// <param name="willRepositionPopoverToRect">On input, the proposed rectangle for the popover. This popover is in the coordinate space of the view in the view parameter. If you want to propose a different rectangle for the popover, put the new value in this parameter.</param>        /// <param name="inView">On input, the proposed view for containing the popover. If you want to propose a different view for the popover, put the new view in this parameter.</param>        //[iOSVersion(7)]        //[Export("popoverController")]        //[Optional]        void PopoverController(UIPopoverController popoverController, UnsafeMutablePointer<CGRect> willRepositionPopoverToRect, AutoreleasingUnsafeMutablePointer<Optional<UIView>> inView);                /// <summary>        /// Asks the delegate if the popover should be dismissed.        /// </summary>        /// <param name="popoverController">The popover controller to be dismissed.</param>        //[iOSVersion(3.2)]        //[Export("popoverControllerShouldDismissPopover")]        //[Optional]        bool PopoverControllerShouldDismissPopover(UIPopoverController popoverController);                /// <summary>        /// Tells the delegate that the popover was dismissed.        /// </summary>        /// <param name="popoverController">The popover controller that was dismissed.</param>        //[iOSVersion(3.2)]        //[Export("popoverControllerDidDismissPopover")]        //[Optional]        void PopoverControllerDidDismissPopover(UIPopoverController popoverController);    }}