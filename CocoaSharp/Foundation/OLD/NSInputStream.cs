using ObjectiveC;using System;using SwiftSharp.Attributes;namespace Foundation{    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSInputStream_Class/index.html#//apple_ref/occ/cl/NSInputStream    /// <summary>    /// NSInputStream is a subclass of NSStream that provides read-only stream functionality.    /// </summary>    [iOSVersion(2)]    public class NSInputStream : NSStream    {        /// <summary>        /// Creates and returns an initialized NSInputStream object for reading from a given NSData object.        /// </summary>        /// <param name="data">The data object from which to read. The contents of data are copied.</param>        /// <returns>An initialized NSInputStream object for reading from data. If data is not an NSData object, this method returns nil.</returns>        [iOSVersion(2)]        [Export("inputStreamWithData")]        public static NSInputStream InputStreamWithData(NSData data) { return null; }                /// <summary>        /// Creates and returns an initialized NSInputStream object that reads data from the file at a given path.        /// </summary>        /// <param name="path">The path to the file.</param>        /// <returns>An initialized NSInputStream object that reads data from the file at path.</returns>        [iOSVersion(2)]        [Export("inputStreamWithFileAtPath")]        public static NSInputStream InputStreamWithFileAtPath(string path) { return null; }                /// <summary>        /// Creates and returns an initialized NSInputStream object that reads data from the file at a given URL.        /// </summary>        /// <param name="url">The URL to the file.</param>        /// <returns>An initialized NSInputStream object that reads data from the URL at url.</returns>        [iOSVersion(4)]        [Export("inputStreamWithURL")]        public static NSInputStream InputStreamWithURL(NSURL url) { return null; }                /// <summary>        /// Initializes and returns an NSInputStream object for reading from a given NSData object.        /// </summary>        /// <param name="data">The data object from which to read. The contents of data are copied.</param>        /// <returns>An initialized NSInputStream object for reading from data.</returns>        [iOSVersion(2)]        public NSInputStream(NSData data) { }                /// <summary>        /// Initializes and returns an NSInputStream object that reads data from the file at a given path.        /// </summary>        /// <param name="fileAtPath">The path to the file.</param>        /// <returns>An initialized NSInputStream object that reads data from the file at path.</returns>        [iOSVersion(2)]        public NSInputStream(string fileAtPath) { }                /// <summary>        /// Initializes and returns an NSInputStream object that reads data from the file at a given URL.        /// </summary>        /// <param name="URL">The URL to the file.</param>        /// <returns>An initialized NSInputStream object that reads data from the file at url.</returns>        [iOSVersion(4)]        public NSInputStream(NSURL URL) { }                /// <summary>        /// Reads up to a given number of bytes into a given buffer.        /// </summary>        /// <param name="buffer">A data buffer. The buffer must be large enough to contain the number of bytes specified by len.</param>        /// <param name="maxLength">The maximum number of bytes to read.</param>        /// <returns>A number indicating the outcome of the operation:</returns>        [iOSVersion(2)]        [Export("read")]        public int Read(CMutablePointer<uint> buffer, int maxLength) { return 0; }                /// <summary>        /// Returns by reference a pointer to a read buffer and, by reference, the number of bytes available, and returns a Boolean value that indicates whether the buffer is available.        /// </summary>        /// <param name="buffer">Upon return, contains a pointer to a read buffer. The buffer is only valid until the next stream operation is performed.</param>        /// <param name="length">Upon return, contains the number of bytes available.</param>        /// <returns>true if the buffer is available, otherwise false.</returns>        [iOSVersion(2)]        [Export("getBuffer")]
        public bool GetBuffer(CMutablePointer<UnsafePointer<uint>> buffer, CMutablePointer<int> length) { return false; }                /// <summary>        /// Returns a Boolean value that indicates whether the receiver has bytes available to read.        /// </summary>        /// <returns>true if the receiver has bytes available to read, otherwise false. May also return true if a read must be attempted in order to determine the availability of bytes.</returns>        [iOSVersion(2)]        [Export("hasBytesAvailable")]        public bool HasBytesAvailable { get; private set; }    }}