using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// NSStream is an abstract class for objects representing streams. Its interface is common to all Cocoa stream classes, including its concrete subclasses NSInputStream and NSOutputStream.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSStream_Class/index.html#//apple_ref/occ/cl/NSStream"/>    [iOSVersion(2)]    [Export("")]    public class NSStream : NSObject//, AnyObject, CVarArgType, Equatable, Hashable, NSObjectProtocol, Printable    {        public NSStream() { }        /// <summary>        /// Returns the receiver’s property for a given key.        /// </summary>        /// <param name="key">The key for one of the receiver&#39;s properties. See Constants for a description of the available property-key constants and associated values.</param>        [iOSVersion(2)]        [Export("propertyForKey")]        [return:Optional]        public virtual AnyObject PropertyForKey(string key) { return default(AnyObject); }                /// <summary>        /// Attempts to set the value of a given property of the receiver and returns a Boolean value that indicates whether the value is accepted by the receiver.        /// </summary>        /// <param name="property">The value for key.</param>        /// <param name="forKey">The key for one of the receiver&#39;s properties. See Constants for a description of the available property-key constants and expected values.</param>        [iOSVersion(2)]        [Export("setProperty")]        public virtual bool SetProperty([Optional] AnyObject property, string forKey) { return default(bool); }                /// <summary>        /// Opens the receiving stream.        /// </summary>        [iOSVersion(2)]        [Export("open")]        public virtual void Open() {  }                /// <summary>        /// Closes the receiver.        /// </summary>        [iOSVersion(2)]        [Export("close")]        public virtual void Close() {  }                /// <summary>        /// Schedules the receiver on a given run loop in a given mode.        /// </summary>        /// <param name="aRunLoop">The run loop on which to schedule the receiver.</param>        /// <param name="forMode">The mode for the run loop.</param>        [iOSVersion(2)]        [Export("scheduleInRunLoop")]        public virtual void ScheduleInRunLoop(NSRunLoop aRunLoop, string forMode) {  }                /// <summary>        /// Removes the receiver from a given run loop running in a given mode.        /// </summary>        /// <param name="aRunLoop">The run loop on which the receiver was scheduled.</param>        /// <param name="forMode">The mode for the run loop.</param>        [iOSVersion(2)]        [Export("removeFromRunLoop")]        public virtual void RemoveFromRunLoop(NSRunLoop aRunLoop, string forMode) {  }                /// <summary>        /// Returns the receiver’s delegate.        /// </summary>        [iOSVersion(2)]        [Export("delegate")]        [Optional]        public NSStreamDelegate Delegate { get; set; }                /// <summary>        /// Returns the receiver’s status.        /// </summary>        [iOSVersion(2)]        [Export("streamStatus")]        public NSStreamStatus StreamStatus { get; private set; }                /// <summary>        /// Returns an NSError object representing the stream error.        /// </summary>        [iOSVersion(2)]        [Export("streamError")]        [Optional]        public NSError StreamError { get; private set; }    }    /// <summary>    /// These constants indicate the current status of a stream. They are returned by streamStatus.    /// </summary>    public enum NSStreamStatus    {        /// <summary>        /// The stream is not open for reading or writing. This status is returned before the underlying call to open a stream but after it’s been created.        /// </summary>        [iOSVersion(2)]        NotOpen,        /// <summary>        /// The stream is in the process of being opened for reading or for writing. For network streams, this status might include the time after the stream was opened, but while network DNS resolution is happening.        /// </summary>        [iOSVersion(2)]        Opening,        /// <summary>        /// The stream is open, but no reading or writing is occurring.        /// </summary>        [iOSVersion(2)]        Open,        /// <summary>        /// Data is being read from the stream. This status would be returned if code on another thread were to call streamStatus on the stream while a read:maxLength: call (NSInputStream) was in progress.        /// </summary>        [iOSVersion(2)]        Reading,        /// <summary>        /// Data is being written to the stream. This status would be returned if code on another thread were to call streamStatus on the stream while a write:maxLength: call (NSOutputStream) was in progress.        /// </summary>        [iOSVersion(2)]        Writing,        /// <summary>        /// There is no more data to read, or no more data can be written to the stream. When this status is returned, the stream is in a “non-blocking” mode and no data are available.        /// </summary>        [iOSVersion(2)]        AtEnd,        /// <summary>        /// The stream is closed (close has been called on it).        /// </summary>        [iOSVersion(2)]        Closed,        /// <summary>        /// The remote end of the connection can’t be contacted, or the connection has been severed for some other reason.        /// </summary>        [iOSVersion(2)]        Error,    }    /// <summary>    /// One or more of these constants may be sent to the delegate as a bit field in the second parameter of stream:handleEvent:.    /// </summary>    public enum NSStreamEvent    {        /// <summary>        /// No event has occurred.        /// </summary>        [iOSVersion(2)]        None,        /// <summary>        /// The open has completed successfully.        /// </summary>        [iOSVersion(2)]        OpenCompleted,        /// <summary>        /// The stream has bytes to be read.        /// </summary>        [iOSVersion(2)]        HasBytesAvailable,        /// <summary>        /// The stream can accept bytes for writing.        /// </summary>        [iOSVersion(2)]        HasSpaceAvailable,        /// <summary>        /// An error has occurred on the stream.        /// </summary>        [iOSVersion(2)]        ErrorOccurred,        /// <summary>        /// The end of the stream has been reached.        /// </summary>        [iOSVersion(2)]        EndEncountered,    }}