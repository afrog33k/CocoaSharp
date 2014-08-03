using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace UIKit{    /// <summary>    /// An instance of the UIAcceleration class, called an acceleration event, represents immediate, three-dimensional acceleration data. To receive accelerometer events, register an application object as a delegate of the shared UIAccelerometer object, as described in UIAccelerometer Class Reference.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIAcceleration_Class/index.html#//apple_ref/occ/cl/UIAcceleration"/>    [iOSVersion(2)]    public class UIAcceleration//:    {    }    /// <summary>    /// The amount of acceleration in a single linear direction.    /// </summary>    [iOSVersion(2)]    public struct UIAccelerationValue    {        static public implicit operator UIAccelerationValue(Double value)        {            return default(UIAccelerationValue);        }        static public implicit operator Double(UIAccelerationValue value)        {            return default(Double);        }    }}