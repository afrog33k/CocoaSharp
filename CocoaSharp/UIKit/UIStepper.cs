using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace UIKit{    /// <summary>    /// A stepper control provides a user interface for incrementing or decrementing a value.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIStepper_Class/index.html#//apple_ref/occ/cl/UIStepper"/>    [iOSVersion(5)]    public class UIStepper : UIControl//, AnyObject, NSCoding, NSObjectProtocol, Reflectable, UIAccessibilityIdentification, UIAppearance, UIAppearanceContainer, UICoordinateSpace, UIDynamicItem, UITraitEnvironment    {        /// <summary>        /// Returns the background image associated with the specified control state.        /// </summary>        /// <param name="state">The control state in which the image is displayed.</param>        [iOSVersion(6)]        [Export("backgroundImageForState")]        public UIImage BackgroundImageForState(UIControlState state) { return default(UIImage); }                /// <summary>        /// Sets the background image for the control when it is in the specified state.        /// </summary>        /// <param name="image">The background image to use for the specified state.</param>        /// <param name="forState">The control state in which you want to display the image.</param>        [iOSVersion(6)]        [Export("setBackgroundImage")]        public void SetBackgroundImage(UIImage image, UIControlState forState) {  }                /// <summary>        /// Returns the image used for the decrement glyph of the control.        /// </summary>        /// <param name="state">The control state in which the image is displayed.</param>        [iOSVersion(6)]        [Export("decrementImageForState")]        public UIImage DecrementImageForState(UIControlState state) { return default(UIImage); }                /// <summary>        /// Sets the image to use for the decrement glyph of the control.        /// </summary>        /// <param name="image">The image to use for the decrement glyph.</param>        /// <param name="forState">The control state in which you want to display the image.</param>        [iOSVersion(6)]        [Export("setDecrementImage")]        public void SetDecrementImage(UIImage image, UIControlState forState) {  }                /// <summary>        /// Returns the divider image for the given combination of left and right states.        /// </summary>        /// <param name="leftState">The state of the left side of the control.</param>        /// <param name="rightSegmentState">The state of the right side of the control.</param>        [iOSVersion(6)]        [Export("dividerImageForLeftSegmentState")]        public UIImage DividerImageForLeftSegmentState(UIControlState leftState, UIControlState rightSegmentState) { return default(UIImage); }                /// <summary>        /// Sets the image to use for the given combination of left and right states.        /// </summary>        /// <param name="image">The divider image to use.</param>        /// <param name="forLeftSegmentState">The state of the left side of the control.</param>        /// <param name="rightSegmentState">The state of the right side of the control.</param>        [iOSVersion(6)]        [Export("setDividerImage")]        public void SetDividerImage(UIImage image, UIControlState forLeftSegmentState, UIControlState rightSegmentState) {  }                /// <summary>        /// Returns the image used for the increment glyph of the control.        /// </summary>        /// <param name="state">The control state in which the image is displayed.</param>        [iOSVersion(6)]        [Export("incrementImageForState")]        public UIImage IncrementImageForState(UIControlState state) { return default(UIImage); }                /// <summary>        /// Sets the image to use for the increment glyph of the control        /// </summary>        /// <param name="image">The image to use for the increment glyph.</param>        /// <param name="forState">The control state.</param>        [iOSVersion(6)]        [Export("setIncrementImage")]        public void SetIncrementImage(UIImage image, UIControlState forState) {  }                /// <summary>        /// The continuous vs. noncontinuous state of the stepper.        /// </summary>        [iOSVersion(5)]        [Export("continuous")]        public bool Continuous { get; set; }                /// <summary>        /// The automatic vs. nonautomatic repeat state of the stepper.        /// </summary>        [iOSVersion(5)]        [Export("autorepeat")]        public bool Autorepeat { get; set; }                /// <summary>        /// The wrap vs. no-wrap state of the stepper.        /// </summary>        [iOSVersion(5)]        [Export("wraps")]        public bool Wraps { get; set; }                /// <summary>        /// The lowest possible numeric value for the stepper.        /// </summary>        [iOSVersion(5)]        [Export("minimumValue")]        public Double MinimumValue { get; set; }                /// <summary>        /// The highest possible numeric value for the stepper.        /// </summary>        [iOSVersion(5)]        [Export("maximumValue")]        public Double MaximumValue { get; set; }                /// <summary>        /// The step, or increment, value for the stepper.        /// </summary>        [iOSVersion(5)]        [Export("stepValue")]        public Double StepValue { get; set; }                /// <summary>        /// The numeric value of the stepper.        /// </summary>        [iOSVersion(5)]        [Export("value")]        public Double Value { get; set; }                /// <summary>        /// The tint color to apply to key elements in the stepper.        /// </summary>        [iOSVersion(6)]        [Export("tintColor")]        public UIColor TintColor { get; set; }    }}