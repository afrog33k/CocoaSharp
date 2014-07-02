using CoreGraphics;
using ObjectiveC;

    /// <summary>
    /// Constants that indicate the appearance changes to make to an input view.
    /// </summary>
    public enum UIInputViewStyle
    {
        /// <summary>
        /// Apply blur behaviors to the view so that it looks like it belongs with the keyboard. Do not apply tinting effects. This style is intended for input views that attach to the top of the keyboard and have a similar theme but that do not look like the keyboard itself.
        /// </summary>
        [iOSVersion(7)]
        Default,

        /// <summary>
        /// Apply both blur and tinting effects to the view to mimic the keyboard background. This style makes the input view match the keyboard appearance and can be used to replace or extend the keyboard.
        /// </summary>
        [iOSVersion(7)]
        Keyboard,
    }