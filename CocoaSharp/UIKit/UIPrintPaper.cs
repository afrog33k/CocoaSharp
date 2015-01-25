using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// An instance of the UIPrintPaper class encapsulates the size of paper used for a print job and the rectangle in which content can be printed.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIPrintPaper_Class/index.html#//apple_ref/occ/cl/UIPrintPaper"/>    [iOSVersion(4.2)]    [Export("")]    public class UIPrintPaper : NSObject//, AnyObject, CVarArgType, Equatable, Hashable, NSObjectProtocol, Printable    {        public UIPrintPaper() { }        /// <summary>        /// Returns the print-paper object that UIKit determines to be the best for a print job based on the given page size and  the paper size–imageable area combinations specific to the printer.        /// </summary>        /// <param name="pageSize">The size of the printed page that your application requests, in points. You should think of this as the size of the physical sheet of paper to use in printing without consideration of the margin.</param>        /// <param name="withPapersFromArray">An array of UIPrintPaper objects that represent combinations of supported paper size and printable areas. The array of objects usually comes directly from the second argument of the printInteractionController:choosePaper: method of the UIPrintInteractionControllerDelegate protocol.</param>        [iOSVersion(4.2)]        [Export("bestPaperForPageSize")]        [return:Optional]        public static UIPrintPaper BestPaperForPageSize(CGSize pageSize, AnyObject[] withPapersFromArray) { return default(UIPrintPaper); }                /// <summary>        /// The size of the sheet to be used for printing. (read-only)        /// </summary>        [iOSVersion(4.2)]        [Export("paperSize")]        public CGSize PaperSize { get; private set; }                /// <summary>        /// The rectangle that represents the portion of the paper that can be imaged upon. (read-only)        /// </summary>        [iOSVersion(4.2)]        [Export("printableRect")]        public CGRect PrintableRect { get; private set; }    }}