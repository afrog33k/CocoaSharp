using CoreGraphics;
using ObjectiveC;
using SwiftSharp.Attributes;

namespace UIKit

    /// <summary>
    /// The presentation style of the alert.
    /// </summary>
    public enum UIAlertViewStyle
    {
        /// <summary>
        /// A standard alert.
        /// </summary>
        [iOSVersion(5)]
        Default,

        /// <summary>
        /// An alert that allows the user to enter text. The text field is obscured.
        /// </summary>
        [iOSVersion(5)]
        SecureTextInput,

        /// <summary>
        /// An alert that allows the user to enter text.
        /// </summary>
        [iOSVersion(5)]
        PlainTextInput,

        /// <summary>
        /// An alert that allows the user to enter a login identifier and password.
        /// </summary>
        [iOSVersion(5)]
        LoginAndPasswordInput,
    }