using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The shared instance of the UIPrintInteractionController class presents a printing user interface and manages the printing of documents, images, and other printable content in iOS.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIPrintInteractionController_Class/index.html#//apple_ref/occ/cl/UIPrintInteractionController"/>    [iOSVersion(4.2)]    [Export("")]    public class UIPrintInteractionController : NSObject//, AnyObject, CVarArgType, Equatable, Hashable, NSObjectProtocol, Printable    {        public UIPrintInteractionController() { }        /// <summary>        /// Returns the shared print-interaction controller object.        /// </summary>        [iOSVersion(4.2)]        [Export("sharedPrintController")]        [return:Optional]        public static UIPrintInteractionController SharedPrintController() { return default(UIPrintInteractionController); }                /// <summary>        /// Returns a Boolean indicating whether the device supports printing.        /// </summary>        [iOSVersion(4.2)]        [Export("isPrintingAvailable")]        public static bool IsPrintingAvailable() { return default(bool); }                /// <summary>        /// Returns whether UIKit can print the contents of a data object.        /// </summary>        /// <param name="data">An instance of the NSData class that contains PDF data or an image in a format supported by the Image I/O framework. See Supported Image Formats in View Programming Guide for iOS for a list of the supported image formats.</param>        [iOSVersion(4.2)]        [Export("canPrintData")]        public static bool CanPrintData(NSData data) { return default(bool); }                /// <summary>        /// Returns whether UIKit can print the file referenced by a URL.        /// </summary>        /// <param name="url">An object representing a URL. Valid NSURL objects must use the file: or assets-library: scheme or any scheme that can return an NSData object with a registered protocol. The file referenced by the URL must contain PDF data or an image in a format supported by the Image I/O framework. See Supported Image Formats in View Programming Guide for iOS for a list of the supported image formats.</param>        [iOSVersion(4.2)]        [Export("canPrintURL")]        public static bool CanPrintURL(NSURL url) { return default(bool); }                /// <summary>        /// Returns a set of the Uniform Type Identifiers for the types of data that UIKit can print.        /// </summary>        [iOSVersion(4.2)]        [Export("printableUTIs")]        public static NSSet PrintableUTIs() { return default(NSSet); }                /// <summary>        /// Presents the iPhone printing user interface in a sheet that can be animated to slide up from the bottom of the screen.        /// </summary>        /// <param name="animated">true to animate the display of the sheet, false to display the sheet immediately.</param>        /// <param name="completionHandler">A block of type UIPrintInteractionCompletionHandler that you implement to handle the conclusion of the print job (for instance, to reset state) and to handle any errors encountered in printing.</param>        [iOSVersion(4.2)]        [Export("presentAnimated")]        public virtual bool PresentAnimated(bool animated, [Optional] UIPrintInteractionCompletionHandler completionHandler) { return default(bool); }                /// <summary>        /// Presents the iPad printing user interface in a popover view that can be animated from a bar-button item.        /// </summary>        /// <param name="item">The UIBarButtonItem object that the user tapped for printing. You are encouraged to use the constant UIBarButtonSystemItemAction when creating a bar-button item for this purpose.</param>        /// <param name="animated">true to animate the printing popover view from item, false to display it immediately.</param>        /// <param name="completionHandler">A block of type UIPrintInteractionCompletionHandler that you implement to handle the conclusion of the print job (for instance, to reset state) and to handle any errors encountered in printing.</param>        [iOSVersion(4.2)]        [Export("presentFromBarButtonItem")]        public virtual bool PresentFromBarButtonItem(UIBarButtonItem item, bool animated, [Optional] UIPrintInteractionCompletionHandler completionHandler) { return default(bool); }                /// <summary>        /// Presents the iPad printing user interface in a popover view that can be animated from any area in a view.        /// </summary>        /// <param name="rect">A rectangle that defines the area from which the printing popover view is animated.</param>        /// <param name="inView">The view providing the coordinate system for rect.</param>        /// <param name="animated">true to animate the printing popover view from item, false to display it immediately.</param>        /// <param name="completionHandler">A block of type UIPrintInteractionCompletionHandler that you implement to handle the conclusion of the print job (for instance, to reset state) and to handle any errors encountered in printing.</param>        [iOSVersion(4.2)]        [Export("presentFromRect")]        public virtual bool PresentFromRect(CGRect rect, UIView inView, bool animated, [Optional] UIPrintInteractionCompletionHandler completionHandler) { return default(bool); }                /// <summary>        /// Dismisses the printing-options sheet or popover.        /// </summary>        /// <param name="animated">true to animate the dismissal, otherwise false.</param>        [iOSVersion(4.2)]        [Export("dismissAnimated")]        public virtual void DismissAnimated(bool animated) {  }                /// <summary>        /// Print directly to the specified printer.        /// </summary>        /// <param name="printer">The printer to use for printing. You can obtain a list of available printers using a UIPrinterPickerController object.</param>        /// <param name="completionHandler">The block to execute when the print operation finishes.</param>        [iOSVersion(8)]        [Export("printToPrinter")]        public virtual bool PrintToPrinter(UIPrinter printer, [Optional] UIPrintInteractionCompletionHandler completionHandler) { return default(bool); }                /// <summary>        /// A single ready-to-print object.        /// </summary>        [iOSVersion(4.2)]        [Export("printingItem")]        [Unwrapped]        public AnyObject PrintingItem { get; set; }                /// <summary>        /// An array of ready-to-print objects.        /// </summary>        [iOSVersion(4.2)]        [Export("printingItems")]        public AnyObject[] PrintingItems { get; set; }                /// <summary>        /// An object that draws pages of printable content when requested by UIKit.        /// </summary>        [iOSVersion(4.2)]        [Export("printPageRenderer")]        [Unwrapped]        public UIPrintPageRenderer PrintPageRenderer { get; set; }                /// <summary>        /// An object that lays out the content of pages based on the kind of content.        /// </summary>        [iOSVersion(4.2)]        [Export("printFormatter")]        [Unwrapped]        public UIPrintFormatter PrintFormatter { get; set; }                /// <summary>        /// An object encapsulating information about the print job.        /// </summary>        [iOSVersion(4.2)]        [Export("printInfo")]        [Unwrapped]        public UIPrintInfo PrintInfo { get; set; }                /// <summary>        /// An object representing the paper size and printing area for the print job. (read-only)        /// </summary>        [iOSVersion(4.2)]        [Export("printPaper")]        [Unwrapped]        public UIPrintPaper PrintPaper { get; private set; }                /// <summary>        /// A Boolean value that determines whether the printing options include the number of copies.        /// </summary>        [iOSVersion(7)]        [Export("showsNumberOfCopies")]        public bool ShowsNumberOfCopies { get; set; }                /// <summary>        /// A Boolean value that determines whether the printing options include a page-range control.        /// </summary>        [iOSVersion(4.2)]        [Export("showsPageRange")]        public bool ShowsPageRange { get; set; }                /// <summary>        /// A Boolean value for enabling the paper selection menu.        /// </summary>        [iOSVersion(8)]        [Export("showsPaperSelectionForLoadedPapers")]        public bool ShowsPaperSelectionForLoadedPapers { get; set; }                /// <summary>        /// The delegate of the print interaction controller.        /// </summary>        [iOSVersion(4.2)]        [Export("delegate")]        [Optional]        public UIPrintInteractionControllerDelegate Delegate { get; set; }                /// <summary>        /// Error codes for UIKit printing errors.        /// </summary>        public int UIPrintingNotAvailableError { get; private set; }    }    /// <summary>    /// The type of block callback for responding to the completion of a print job or handing printing errors.    /// </summary>    [iOSVersion(4.2)]    public struct UIPrintInteractionCompletionHandler    {        static public implicit operator UIPrintInteractionCompletionHandler(Action<UIPrintInteractionController, bool, NSError> value)        {            return default(UIPrintInteractionCompletionHandler);        }        static public implicit operator Action<UIPrintInteractionController, bool, NSError>(UIPrintInteractionCompletionHandler value)        {            return default(Action<UIPrintInteractionController, bool, NSError>);        }    }}