using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// The NSURLSessionDownloadDelegate protocol defines delegate methods that you should implement when using NSURLSession download tasks. In addition to these methods, be sure to implement the methods in the NSURLSessionTaskDelegate and NSURLSessionDelegate protocols to handle events common to all task types and session-level events, respectively.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Foundation/Reference/NSURLSessionDownloadDelegate_protocol/index.html#//apple_ref/occ/intf/NSURLSessionDownloadDelegate"/>    [iOSVersion(7)]    [Export("")]    public interface NSURLSessionDownloadDelegate//: NSObjectProtocol, NSURLSessionDelegate, NSURLSessionTaskDelegate    {        /// <summary>        /// Tells the delegate that the download task has resumed downloading. (required)        /// </summary>        /// <param name="session">The session containing the download task that finished.</param>        /// <param name="downloadTask">The download task that resumed. See explanation in the discussion.</param>        /// <param name="didResumeAtOffset">If the file&#39;s cache policy or last modified date prevents reuse of the existing content, then this value is zero. Otherwise, this value is an integer representing the number of bytes on disk that do not need to be retrieved again.        ///     Note        ///     	In some situations, it may be possible for the transfer to resume earlier in the file than where the previous transfer ended.</param>        /// <param name="expectedTotalBytes">The expected length of the file, as provided by the Content-Length header. If this header was not provided, the value is NSURLSessionTransferSizeUnknown.</param>        //[iOSVersion(7)]        //[InheritOptional]        //void URLSession(NSURLSession session, NSURLSessionDownloadTask downloadTask, Int64 didResumeAtOffset, Int64 expectedTotalBytes);                /// <summary>        /// Periodically informs the delegate about the download’s progress. (required)        /// </summary>        /// <param name="session">The session containing the download task.</param>        /// <param name="downloadTask">The download task.</param>        /// <param name="didWriteData">The number of bytes transferred since the last time this delegate method was called.</param>        /// <param name="totalBytesWritten">The total number of bytes transferred so far.</param>        /// <param name="totalBytesExpectedToWrite">The expected length of the file, as provided by the Content-Length header. If this header was not provided, the value is NSURLSessionTransferSizeUnknown.</param>        //[iOSVersion(7)]        //[InheritOptional]        //void URLSession(NSURLSession session, NSURLSessionDownloadTask downloadTask, Int64 didWriteData, Int64 totalBytesWritten, Int64 totalBytesExpectedToWrite);                /// <summary>        /// Tells the delegate that a download task has finished downloading. (required)        /// </summary>        /// <param name="session">The session containing the download task that finished.</param>        /// <param name="downloadTask">The download task that finished.</param>        /// <param name="didFinishDownloadingToURL">A file URL for the temporary file. Because the file is temporary, you must either open the file for reading or move it to a permanent location in your app’s sandbox container directory before returning from this delegate method.        ///   If you choose to open the file for reading, you should do the actual reading in another thread to avoid blocking the delegate queue.</param>        [iOSVersion(7)]        void URLSession(NSURLSession session, NSURLSessionDownloadTask downloadTask, NSURL didFinishDownloadingToURL);    }}