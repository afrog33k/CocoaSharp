using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace UIKit{    /// <summary>    /// A UITableViewRowAction object defines a single action to present when the user swipes in a table row. In an editable table, performing a horizontal swipe in a row moves the row content aside and reveals a button to delete the row. This class lets you define custom actions for a given row in your table. Each instance represents a single action to perform and includes the text and formatting information for the corresponding button.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UITableViewRowAction_class/index.html#//apple_ref/occ/cl/UITableViewRowAction"/>    [iOSVersion(8)]    public class UITableViewRowAction : NSObject//, AnyObject, NSCopying, NSObjectProtocol    {        /// <summary>        /// Creates and returns a new table view row action object.        /// </summary>        /// <param name="style">The style characteristics to apply to the button. You use this value to apply default appearance characteristics to the button. These characteristics can impart information about what the button does. For example, you can use this to indicate an action is destructive to the underlying data. For a list of possible style values, see UITableViewRowActionStyle.</param>        /// <param name="title">The string to display in the button. Specify a string localized for the user’s current language.</param>        /// <param name="handler">The block to execute when the user taps the button associated with this action. UIKit makes a copy of the block you provide. When the user selects the action represented by this object, UIKit executes your handler block on the app’s main thread. This parameter must not be nil. This block has no return value and takes the following parameters:        ///       action        ///   The action object representing the action that the user selected.        ///       indexPath        ///   The table row that the user acted on.</param>        [iOSVersion(8)]        [Export("convenience init")]        public UITableViewRowAction(UITableViewRowActionStyle style, string title, Action<UITableViewRowAction, NSIndexPath> handler) { }                /// <summary>        /// The style applied to the action button. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("style")]        public UITableViewRowActionStyle Style { get; private set; }                /// <summary>        /// The title of the action button.        /// </summary>        [iOSVersion(8)]        [Export("title")]        public string Title { get; set; }                /// <summary>        /// The background color of the action button.        /// </summary>        [iOSVersion(8)]        [Export("backgroundColor")]        public UIColor BackgroundColor { get; set; }                /// <summary>        /// The visual effect to apply to the button.        /// </summary>        [iOSVersion(8)]        [Export("backgroundEffect")]        public UIVisualEffect BackgroundEffect { get; set; }    }    /// <summary>    /// Constants that help define the appearance of action buttons.    /// </summary>    [iOSVersion(8)]    public enum UITableViewRowActionStyle    {        /// <summary>        /// Apply the default style to the button. This style does not apply any special coloring to the button.        /// </summary>        [iOSVersion(8)]        Default,        /// <summary>        /// Apply a style that reflects standard non-destructive actions.        /// </summary>        [iOSVersion(8)]        Normal,    }}