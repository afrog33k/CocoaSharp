using ObjectiveC;
using System;
using SwiftSharp.Attributes;
using Foundation;

namespace UIKit
{
    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIKeyCommand_class/index.html#//apple_ref/occ/cl/UIKeyCommand
    /// <summary>
    /// The UIKeyCommand class specifies a key presses performed on a hardware keyboard and the resulting action that should take place. Hardware keyboards allow a user to hold down the Control, Option, Command, or other modifier key and press a key in combination to initiate commands such as cut, copy, or paste. You can use instances of this class to define custom command sequences that your app recognizes and then provide an appropriate response.
    /// </summary>
    [iOSVersion(7)]
    public class UIKeyCommand : NSObject
    {
        /// <summary>
        /// Creates and returns a new key command object that matches the specified input.
        /// </summary>
        /// <param name="input">The keys that must be pressed by the user. The string must contain one or more characters corresponding to the keys that were pressed. For a list of special characters that do not have a textual representation, see “Input Strings for Special Keys”.</param>
        /// <param name="modifierFlags">The bit mask of modifier keys that must be pressed. You can use this parameter to specify which modifier keys (Command, Option, and so on) must also be pressed by the user. You may specify more than one modifier key. For a list of possible values, see “UIKeyModifierFlags”.</param>
        /// <param name="action">The action method to execute on the responder object.</param>
        /// <returns>The key command object.</returns>
        [iOSVersion(7)]
        public UIKeyCommand Init(string input, UIKeyModifierFlags modifierFlags, Selector action) { return new UIKeyCommand(); }
        
        /// <summary>
        /// The string of characters corresponding to the keys that must be pressed to match this key command. (read-only)
        /// </summary>
        [iOSVersion(7)]
        [Export("input")]
        public string Input { get; private set; }
        
        /// <summary>
        /// The bit mask of modifier flags that must be pressed to match this key command. (read-only)
        /// </summary>
        [iOSVersion(7)]
        [Export("modifierFlags")]
        public UIKeyModifierFlags ModifierFlags { get; private set; }

        /// <summary>
        /// These constants represent the text input strings that correspond to special non visible keys.
        /// </summary>
        
        /// <summary>
        /// The string representing the up arrow key.
        /// </summary>
        [iOSVersion(7)]
        public string UIKeyInputUpArrow { get; private set; }
        
        /// <summary>
        /// The string representing the down arrow key.
        /// </summary>
        [iOSVersion(7)]
        public string UIKeyInputDownArrow { get; private set; }
        
        /// <summary>
        /// The string representing the left arrow key.
        /// </summary>
        [iOSVersion(7)]
        public string UIKeyInputLeftArrow { get; private set; }
        
        /// <summary>
        /// The string representing the right arrow key.
        /// </summary>
        [iOSVersion(7)]
        public string UIKeyInputRightArrow { get; private set; }
        
        /// <summary>
        /// The string representing the Escape key.
        /// </summary>
        [iOSVersion(7)]
        public string UIKeyInputEscape { get; private set; }
    }

    /// <summary>
    /// These constants indicate which modifier keys are pressed.
    /// </summary>
    public enum UIKeyModifierFlags
    {
        /// <summary>
        /// The Caps Lock key is currently engaged.
        /// </summary>
        [iOSVersion(7)]
        AlphaShift,

        /// <summary>
        /// The Shift key is pressed.
        /// </summary>
        [iOSVersion(7)]
        Shift,

        /// <summary>
        /// The Control key is pressed.
        /// </summary>
        [iOSVersion(7)]
        Control,

        /// <summary>
        /// The Option key is pressed.
        /// </summary>
        [iOSVersion(7)]
        Alternate,

        /// <summary>
        /// The Command key is pressed.
        /// </summary>
        [iOSVersion(7)]
        Command,

        /// <summary>
        /// The key is located on the numeric keypad.
        /// </summary>
        [iOSVersion(7)]
        NumericPad,
    }
}