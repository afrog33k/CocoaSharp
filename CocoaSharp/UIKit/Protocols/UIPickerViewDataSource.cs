using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace UIKit{    /// <summary>    /// The UIPickerViewDataSource protocol must be adopted by an object that mediates between a UIPickerView object and your application’s data model for that picker view. The data source provides the picker view with the number of components, and the number of rows in each component, for displaying the picker view data. Both methods in this protocol are required.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/iPhone/Reference/UIPickerViewDataSource_Protocol/index.html#//apple_ref/occ/intf/UIPickerViewDataSource"/>    [iOSVersion(2)]    public interface UIPickerViewDataSource//: NSObjectProtocol    {        /// <summary>        /// Called by the picker view when it needs the number of components. (required)        /// </summary>        /// <param name="pickerView">The picker view requesting the data.</param>        [iOSVersion(2)]        [Export("numberOfComponentsInPickerView")]        int NumberOfComponentsInPickerView(UIPickerView pickerView);                /// <summary>        /// Called by the picker view when it needs the number of rows for a specified component. (required)        /// </summary>        /// <param name="pickerView">The picker view requesting the data.</param>        /// <param name="numberOfRowsInComponent">A zero-indexed number identifying a component of pickerView. Components are numbered left-to-right.</param>        [iOSVersion(2)]        [Export("pickerView")]        int PickerView(UIPickerView pickerView, int numberOfRowsInComponent);    }}