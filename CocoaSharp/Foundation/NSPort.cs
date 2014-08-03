using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// NSPort is an abstract class that represents a communication channel. Communication occurs between NSPort objects, which typically reside in different threads or tasks. The distributed objects system uses NSPort objects to send NSPortMessage objects back and forth. You should implement interapplication communication using distributed objects whenever possible and use NSPort objects only when necessary.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSPort_Class/index.html#//apple_ref/occ/cl/NSPort"/>    [iOSVersion(2)]    public class NSPort : NSObject//, AnyObject, NSCoding, NSCopying, NSObjectProtocol    {        /// <summary>        /// Marks the receiver as invalid and posts an NSPortDidBecomeInvalidNotification to the default notification center.        /// </summary>        [iOSVersion(2)]        [Export("invalidate")]        public void Invalidate() {  }                /// <summary>        /// Sets the receiver’s delegate to a given object.        /// </summary>        /// <param name="anObject">The delegate for the receiver.</param>        [iOSVersion(2)]        [Export("setDelegate")]        public void SetDelegate(NSPortDelegate anObject) {  }                /// <summary>        /// Returns the receiver’s delegate.        /// </summary>        [iOSVersion(2)]        [Export("delegate")]        public NSPortDelegate Delegate() { return default(NSPortDelegate); }                /// <summary>        /// This method is provided for subclasses that have custom types of NSPort.        /// </summary>        /// <param name="limitDate">The last instant that a message may be sent.</param>        /// <param name="components">The message components.</param>        /// <param name="from">The receive port.</param>        /// <param name="reserved">The number of bytes reserved for the header.</param>        [iOSVersion(2)]        [Export("sendBeforeDate")]        public bool SendBeforeDate(NSDate limitDate, NSMutableArray components, NSPort from, int reserved) { return default(bool); }                /// <summary>        /// This method is provided for subclasses that have custom types of NSPort.        /// </summary>        /// <param name="limitDate">The last instant that a message may be sent.</param>        /// <param name="msgid">The message ID.</param>        /// <param name="components">The message components.</param>        /// <param name="from">The receive port.</param>        /// <param name="reserved">The number of bytes reserved for the header.</param>        [iOSVersion(2)]        [Export("sendBeforeDate")]        public bool SendBeforeDate(NSDate limitDate, int msgid, NSMutableArray components, NSPort from, int reserved) { return default(bool); }                /// <summary>        /// This method should be implemented by a subclass to stop monitoring of a port when removed from a give run loop in a given input mode.        /// </summary>        /// <param name="runLoop">The run loop from which to remove the receiver.</param>        /// <param name="forMode">The run loop mode from which to remove the receiver</param>        [iOSVersion(2)]        [Export("removeFromRunLoop")]        public void RemoveFromRunLoop(NSRunLoop runLoop, string forMode) {  }                /// <summary>        /// This method should be implemented by a subclass to set up monitoring of a port when added to a given run loop in a given input mode.        /// </summary>        /// <param name="runLoop">The run loop to which to add the receiver.</param>        /// <param name="forMode">The run loop mode to which to add the receiver</param>        [iOSVersion(2)]        [Export("scheduleInRunLoop")]        public void ScheduleInRunLoop(NSRunLoop runLoop, string forMode) {  }                /// <summary>        /// Returns the number of bytes of space reserved by the receiver for sending data.        /// </summary>        [iOSVersion(2)]        [Export("reservedSpaceLength")]        public int ReservedSpaceLength { get; private set; }    }    /// <summary>    /// An NSSocketPort object cannot detect when its connection to a remote port is lost, even if the remote port is on the same machine. Therefore, it cannot invalidate itself and post this notification. Instead, you must detect the timeout error when the next message is sent.    /// </summary>    [iOSVersion(2)]    public class NSPortDidBecomeInvalidNotification : NSNotification    {        public NSPortDidBecomeInvalidNotification() : base("", null) { }    }}