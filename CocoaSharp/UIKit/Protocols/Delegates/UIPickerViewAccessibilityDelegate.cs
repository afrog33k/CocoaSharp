using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UIPickerViewAccessibilityDelegate protocol defines methods you can implement to provide accessibility information for individual components of a picker view.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIPickerViewAccessibilityDelegate_Protocol/index.html#//apple_ref/occ/intf/UIPickerViewAccessibilityDelegate"/>    [iOSVersion(4)]    public interface UIPickerViewAccessibilityDelegate//: NSObjectProtocol, UIPickerViewDelegate    {        /// <summary>        /// Returns a label that identifies the picker view component.        /// </summary>        /// <param name="pickerView"></param>        /// <param name="accessibilityLabelForComponent"></param>        //[iOSVersion(4)]        //[Export("pickerView")]        //[Optional]        string PickerView(UIPickerView pickerView, int accessibilityLabelForComponent);                /// <summary>        /// Returns a hint that describes the result of performing an action on the picker view component.        /// </summary>        /// <param name="pickerView"></param>        /// <param name="accessibilityHintForComponent"></param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        //[iOSVersion(4)]        //[Export("pickerView")]        //[Optional]        //[IgnoreParameter("NAME_YOUR_PARAMS")]        string PickerView(UIPickerView pickerView, int accessibilityHintForComponent, bool NAME_YOUR_PARAMS = false);    }}