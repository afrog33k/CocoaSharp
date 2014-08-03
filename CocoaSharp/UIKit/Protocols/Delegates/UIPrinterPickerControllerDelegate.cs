using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace UIKit{    /// <summary>    /// The UIPrinterPickerControllerDelegate protocol defines methods for managing the presentation and dismissal of a printer picker interface. You also use the methods of this protocol to influence the content displayed in the picker and to respond when the user selects a printer.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIPrinterPickerControllerDelegate_protocol/index.html#//apple_ref/occ/intf/UIPrinterPickerControllerDelegate"/>    [iOSVersion(8)]    public interface UIPrinterPickerControllerDelegate//: NSObjectProtocol    {        /// <summary>        /// Asks the delegate if the specified printer should be included in the picker.        /// </summary>        /// <param name="printerPickerController">The printer picker controller that is asking the delegate for information.</param>        /// <param name="shouldShowPrinter">The printer object for the delegate to consider.</param>        [iOSVersion(8)]        [Export("printerPickerController")]        bool PrinterPickerController(UIPrinterPickerController printerPickerController, UIPrinter shouldShowPrinter);                /// <summary>        /// Tells the delegate that a printer was selected.        /// </summary>        /// <param name="printerPickerController">The printer picker controller that is providing your delegate with information.</param>        [iOSVersion(8)]        [Export("printerPickerControllerDidSelectPrinter")]        void PrinterPickerControllerDidSelectPrinter(UIPrinterPickerController printerPickerController);                /// <summary>        /// Asks the delegate to provide the view controller to act as the parent of the printer picker.        /// </summary>        /// <param name="printerPickerController">The printer picker controller object that made the request.</param>        [iOSVersion(8)]        [Export("printerPickerControllerParentViewController")]        UIViewController PrinterPickerControllerParentViewController(UIPrinterPickerController printerPickerController);                /// <summary>        /// Tells the delegate that the printer picker is about to be displayed.        /// </summary>        /// <param name="printerPickerController">The printer picker controller object being displayed.</param>        [iOSVersion(8)]        [Export("printerPickerControllerWillPresent")]        void PrinterPickerControllerWillPresent(UIPrinterPickerController printerPickerController);                /// <summary>        /// Tells the delegate that the printer picker was displayed and is now visible.        /// </summary>        /// <param name="printerPickerController">The printer picker controller object being displayed.</param>        [iOSVersion(8)]        [Export("printerPickerControllerDidPresent")]        void PrinterPickerControllerDidPresent(UIPrinterPickerController printerPickerController);                /// <summary>        /// Tells the delegate that the printer picker is about to be dismissed.        /// </summary>        /// <param name="printerPickerController">The printer picker controller object being dismissed.</param>        [iOSVersion(8)]        [Export("printerPickerControllerWillDismiss")]        void PrinterPickerControllerWillDismiss(UIPrinterPickerController printerPickerController);                /// <summary>        /// Tells the delegate that the printer picker was dismissed.        /// </summary>        /// <param name="printerPickerController">The printer picker controller object that was dismissed.</param>        [iOSVersion(8)]        [Export("printerPickerControllerDidDismiss")]        void PrinterPickerControllerDidDismiss(UIPrinterPickerController printerPickerController);    }}