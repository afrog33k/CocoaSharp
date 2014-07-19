using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSFileHandle_Class/index.html#//apple_ref/occ/cl/NSFileHandle
    /// <summary>
    /// The NSFileHandle class is an object-oriented wrapper for a file descriptor. You use file handle objects to access data associated with files, sockets, pipes, and devices. For files, you can read, write, and seek within the file. For sockets, pipes, and devices, you can use a file handle object to monitor the device and process data asynchronously.
    /// </summary>
    [iOSVersion(2)]
    public class NSFileHandle : NSObject
    {
        /// <summary>
        /// Returns a file handle initialized for reading the file, device, or named socket at the specified path.
        /// </summary>
        /// <param name="forReadingAtPath">The path to the file, device, or named socket to access.</param>
        /// <returns>The initialized file handle object or nil if no file exists at path.</returns>
        [iOSVersion(2)]
        public NSFileHandle(string forReadingAtPath) { }
        
        /// <summary>
        /// Returns a file handle initialized for reading the file, device, or named socket at the specified URL.
        /// </summary>
        /// <param name="url">The URL of the file, device, or named socket to access.</param>
        /// <param name="error">If an error occurs, upon return contains an NSError object that describes the problem. Pass NULL if you do not want error information.</param>
        /// <returns>The initialized file handle object or nil if no file exists at url.</returns>
        [iOSVersion(4)]
        [Export("fileHandleForReadingFromURL")]
        public static NSFileHandle FileHandleForReadingFromURL(NSURL url, NSErrorPointer error) { return null; }
        
        /// <summary>
        /// !! IMPORTANT !! Name the parameter you're using!
        /// 
        /// Returns a file handle initialized for writing (or reading and writing) to the file, device, or named socket at the specified path.
        /// </summary>
        /// <param name="forWritingAtPath">The path to the file, device, or named socket to access.</param>
        /// <param name="forUpdatingAtPath">The path to the file, device, or named socket to access.</param>
        /// <returns>The initialized file handle object or nil if no file exists at path.</returns>
        [iOSVersion(2)]
        public NSFileHandle(string forWritingAtPath = "", string forUpdatingAtPath = "") { }
        
        /// <summary>
        /// Returns a file handle initialized for writing to the file, device, or named socket at the specified URL.
        /// </summary>
        /// <param name="url">The URL of the file, device, or named socket to access.</param>
        /// <param name="error">If an error occurs, upon return contains an NSError object that describes the problem. Pass NULL if you do not want error information.</param>
        /// <returns>The initialized file handle object or nil if no file exists at url.</returns>
        [iOSVersion(4)]
        [Export("fileHandleForWritingToURL")]
        public static NSFileHandle FileHandleForWritingToURL(NSURL url, NSErrorPointer error) { return null; }
        
        /// <summary>
        /// Returns a file handle initialized for reading and writing to the file, device, or named socket at the specified URL.
        /// </summary>
        /// <param name="url">The URL of the file, device, or named socket to access.</param>
        /// <param name="error">If an error occurs, upon return contains an NSError object that describes the problem. Pass NULL if you do not want error information.</param>
        /// <returns>The initialized file handle object or nil if no file exists at url.</returns>
        [iOSVersion(4)]
        [Export("fileHandleForUpdatingURL")]
        public static NSFileHandle FileHandleForUpdatingURL(NSURL url, NSErrorPointer error) { return null; }
        
        /// <summary>
        /// Returns the file handle associated with the standard error file.
        /// </summary>
        /// <returns>The shared file handle associated with the standard error file.</returns>
        [iOSVersion(2)]
        [Export("fileHandleWithStandardError")]
        public static NSFileHandle FileHandleWithStandardError() { return null; }
        
        /// <summary>
        /// Returns the file handle associated with the standard input file.
        /// </summary>
        /// <returns>The shared file handle associated with the standard input file.</returns>
        [iOSVersion(2)]
        [Export("fileHandleWithStandardInput")]
        public static NSFileHandle FileHandleWithStandardInput() { return null; }
        
        /// <summary>
        /// Returns the file handle associated with the standard output file.
        /// </summary>
        /// <returns>The shared file handle associated with the standard output file.</returns>
        [iOSVersion(2)]
        [Export("fileHandleWithStandardOutput")]
        public static NSFileHandle FileHandleWithStandardOutput() { return null; }
        
        /// <summary>
        /// Returns a file handle associated with a null device.
        /// </summary>
        /// <returns>A file handle associated with a null device.</returns>
        [iOSVersion(2)]
        [Export("fileHandleWithNullDevice")]
        public static NSFileHandle FileHandleWithNullDevice() { return null; }
        
        /// <summary>
        /// Initializes and returns a file handle object associated with the specified file descriptor.
        /// </summary>
        /// <param name="fileDescriptor">The POSIX file descriptor with which to initialize the file handle. This descriptor represents an open file or socket that you created previously. For example, when creating a file handle for a socket, you would pass the value returned by the socket function.</param>
        /// <returns>A file handle initialized with fileDescriptor.</returns>
        [iOSVersion(2)]
        public NSFileHandle(Cint fileDescriptor) { }
        
        /// <summary>
        /// Initializes and returns a file handle object associated with the specified file descriptor and deallocation policy.
        /// </summary>
        /// <param name="fileDescriptor">The POSIX file descriptor with which to initialize the file handle.</param>
        /// <param name="closeOnDealloc">true if the returned file handle object should take ownership of the file descriptor and close it for you or false if you want to maintain ownership of the file descriptor.</param>
        /// <returns>An initialized file handle object.</returns>
        [iOSVersion(2)]
        public NSFileHandle(Cint fileDescriptor, bool closeOnDealloc) { }
        
        /// <summary>
        /// Returns the file descriptor associated with the receiver.
        /// </summary>
        /// <returns>The POSIX file descriptor associated with the receiver.</returns>
        [iOSVersion(2)]
        [Export("fileDescriptor")]
        public Cint FileDescriptor { get; private set; }
        
        /// <summary>
        /// Returns the data currently available in the receiver.
        /// </summary>
        /// <returns>The data currently available through the receiver, up to the the maximum size that can be represented by an NSData object.</returns>
        [iOSVersion(2)]
        [Export("availableData")]
        public NSData AvailableData { get; private set; }
        
        /// <summary>
        /// Synchronously reads the available data up to the end of file or maximum number of bytes.
        /// </summary>
        /// <returns>The data available through the receiver up to maximum size that can be represented by an NSData object or, if a communications channel, until an end-of-file indicator is returned.</returns>
        [iOSVersion(2)]
        [Export("readDataToEndOfFile")]
        public NSData ReadDataToEndOfFile() { return null; }
        
        /// <summary>
        /// Synchronously reads data up to the specified number of bytes.
        /// </summary>
        /// <param name="length">The number of bytes to read from the receiver.</param>
        /// <returns>The data available through the receiver up to a maximum of length bytes, or the maximum size that can be represented by an NSData object, whichever is the smaller.</returns>
        [iOSVersion(2)]
        [Export("readDataOfLength")]
        public NSData ReadDataOfLength(int length) { return null; }
        
        /// <summary>
        /// Synchronously writes the specified data to the receiver.
        /// </summary>
        /// <param name="data">The data to be written.</param>
        [iOSVersion(2)]
        [Export("writeData")]
        public void WriteData(NSData data) { }
        
        /// <summary>
        /// The block to use for reading the contents of the file handle asynchronously.
        /// </summary>
        [iOSVersion(5)]
        [Export("readabilityHandler")]
        public Action<NSFileHandle> ReadabilityHandler { get; set; }
        
        /// <summary>
        /// The block to use for writing the contents of the file handle asynchronously.
        /// </summary>
        [iOSVersion(5)]
        [Export("writeabilityHandler")]
        public Action<NSFileHandle> WriteabilityHandler { get; set; }
        
        /// <summary>
        /// Accepts a socket connection (for stream-type sockets only) in the background and creates a file handle for the “near” (client) end of the communications channel.
        /// </summary>
        [iOSVersion(2)]
        [Export("acceptConnectionInBackgroundAndNotify")]
        public void AcceptConnectionInBackgroundAndNotify() { }
        
        /// <summary>
        /// Accepts a socket connection (for stream-type sockets only) in the background and creates a file handle for the “near” (client) end of the communications channel.
        /// </summary>
        /// <param name="modes">The runloop modes in which the connection accepted notification can be posted.</param>
        [iOSVersion(2)]
        [Export("acceptConnectionInBackgroundAndNotifyForModes")]
        public void AcceptConnectionInBackgroundAndNotifyForModes(AnyObject[] modes) { }
        
        /// <summary>
        /// Reads from the file or communications channel in the background and posts a notification when finished.
        /// </summary>
        [iOSVersion(2)]
        [Export("readInBackgroundAndNotify")]
        public void ReadInBackgroundAndNotify() { }
        
        /// <summary>
        /// Reads from the file or communications channel in the background and posts a notification when finished.
        /// </summary>
        /// <param name="modes">The runloop modes in which the read completion notification can be posted.</param>
        [iOSVersion(2)]
        [Export("readInBackgroundAndNotifyForModes")]
        public void ReadInBackgroundAndNotifyForModes(AnyObject[] modes) { }
        
        /// <summary>
        /// Reads to the end of file from the file or communications channel in the background and posts a notification when finished.
        /// </summary>
        [iOSVersion(2)]
        [Export("readToEndOfFileInBackgroundAndNotify")]
        public void ReadToEndOfFileInBackgroundAndNotify() { }
        
        /// <summary>
        /// Reads to the end of file from the file or communications channel in the background and posts a notification when finished.
        /// </summary>
        /// <param name="modes">The runloop modes in which the read completion notification can be posted.</param>
        [iOSVersion(2)]
        [Export("readToEndOfFileInBackgroundAndNotifyForModes")]
        public void ReadToEndOfFileInBackgroundAndNotifyForModes(AnyObject[] modes) { }
        
        /// <summary>
        /// Asynchronously checks to see if data is available.
        /// </summary>
        [iOSVersion(2)]
        [Export("waitForDataInBackgroundAndNotify")]
        public void WaitForDataInBackgroundAndNotify() { }
        
        /// <summary>
        /// Asynchronously checks to see if data is available.
        /// </summary>
        /// <param name="modes">The runloop modes in which the data available notification can be posted.</param>
        [iOSVersion(2)]
        [Export("waitForDataInBackgroundAndNotifyForModes")]
        public void WaitForDataInBackgroundAndNotifyForModes(AnyObject[] modes) { }
        
        /// <summary>
        /// Returns the position of the file pointer within the file represented by the receiver.
        /// </summary>
        /// <returns>The position of the file pointer within the file represented by the receiver.</returns>
        [iOSVersion(2)]
        [Export("offsetInFile")]
        public CUnsignedLongLong OffsetInFile { get; private set; }
        
        /// <summary>
        /// Puts the file pointer at the end of the file referenced by the receiver and returns the new file offset.
        /// </summary>
        /// <returns>The file offset with the file pointer at the end of the file. This is therefore equal to the size of the file.</returns>
        [iOSVersion(2)]
        [Export("seekToEndOfFile")]
        public CUnsignedLongLong SeekToEndOfFile() { return null; }
        
        /// <summary>
        /// Moves the file pointer to the specified offset within the file represented by the receiver.
        /// </summary>
        /// <param name="offset">The offset to seek to.</param>
        [iOSVersion(2)]
        [Export("seekToFileOffset")]
        public void SeekToFileOffset(CUnsignedLongLong offset) { }
        
        /// <summary>
        /// Disallows further access to the represented file or communications channel and signals end of file on communications channels that permit writing.
        /// </summary>
        [iOSVersion(2)]
        [Export("closeFile")]
        public void CloseFile() { }
        
        /// <summary>
        /// Causes all in-memory data and attributes of the file represented by the receiver to be written to permanent storage.
        /// </summary>
        [iOSVersion(2)]
        [Export("synchronizeFile")]
        public void SynchronizeFile() { }
        
        /// <summary>
        /// Truncates or extends the file represented by the receiver to a specified offset within the file and puts the file pointer at that position.
        /// </summary>
        /// <param name="offset">The offset within the file that will mark the new end of the file.</param>
        [iOSVersion(2)]
        [Export("truncateFileAtOffset")]
        public void TruncateFileAtOffset(CUnsignedLongLong offset) { }
        
        /// <summary>
        /// Strings that are used as keys in a userinfo dictionary in a file handle notification.
        /// </summary>
        
        /// <summary>
        /// A key in the userinfo dictionary in a NSFileHandleConnectionAcceptedNotification notification.
        /// </summary>
        [iOSVersion(2)]
        public string NSFileHandleNotificationFileHandleItem { get; private set; }
        
        /// <summary>
        /// A key in the userinfo dictionary in a NSFileHandleReadCompletionNotification and NSFileHandleReadToEndOfFileCompletionNotification.
        /// </summary>
        [iOSVersion(2)]
        public string NSFileHandleNotificationDataItem { get; private set; }
        
        /// <summary>
        /// Constant that defines the name of a file operation exception.
        /// </summary>
        [Export("NSFileHandleOperationException")]
        public string NSFileHandleOperationException { get; private set; }
        
        /// <summary>
        /// Constant that is currently unused.
        /// </summary>
        [Export("NSFileHandleNotificationMonitorModes")]
        public string NSFileHandleNotificationMonitorModes { get; private set; }
    }
    
    /// <summary>
    /// This notification is posted when an acceptConnectionInBackgroundAndNotifyacceptConnectionInBackgroundAndNotifyForModes:NSFileHandle
    /// The notification object is the NSFileHandle object that sent the notification. The userInfo dictionary contains the following information:
    /// NSFileHandleNotificationFileHandleItem: The NSFileHandle object representing the “near” end of a socket connection
    /// @"NSFileHandleError": An NSNumber object containing an integer representing the UNIX-type error which occurred
    /// </summary>
    [iOSVersion(2)]
    public class NSFileHandleConnectionAcceptedNotification : NSNotification
    {
        public NSFileHandleConnectionAcceptedNotification() : base("", null) { }
    }
    
    /// <summary>
    /// This notification is posted when the file handle determines that data is currently available for reading in a file or at a communications channel.
    /// waitForDataInBackgroundAndNotifywaitForDataInBackgroundAndNotifyForModes:NSFileHandle
    /// The notification object is the NSFileHandle object that sent the notification. This notification does not contain a userInfo dictionary.NSFileHandleDataAvailableNotification
    /// </summary>
    [iOSVersion(2)]
    public class NSFileHandleDataAvailableNotification : NSNotification
    {
        public NSFileHandleDataAvailableNotification() : base("", null) { }
    }
    
    /// <summary>
    /// This notification is posted when the file handle reads the data currently available in a file or at a communications channel.
    /// userInforeadInBackgroundAndNotifyreadInBackgroundAndNotifyForModes:NSFileHandle
    /// The notification object is the NSFileHandle object that sent the notification. The userInfo dictionary contains the following information:
    /// NSFileHandleNotificationDataItem: An NSData object containing the available data read from a socket connection
    /// @"NSFileHandleError": An NSNumber object containing an integer representing the UNIX-type error which occurred
    /// </summary>
    [iOSVersion(2)]
    public class NSFileHandleReadCompletionNotification : NSNotification
    {
        public NSFileHandleReadCompletionNotification() : base("", null) { }
    }
    
    /// <summary>
    /// This notification is posted when the file handle reads all data in the file or, if a communications channel, until the other process signals the end of data.
    /// userInforeadToEndOfFileInBackgroundAndNotifyreadToEndOfFileInBackgroundAndNotifyForModes:NSFileHandle
    /// The notification object is the NSFileHandle object that sent the notification. The userInfo dictionary contains the following information:
    /// NSFileHandleNotificationDataItem: An NSData object containing the available data read from a socket connection
    /// @"NSFileHandleError": An NSNumber object containing an integer representing the UNIX-type error which occurred
    /// </summary>
    [iOSVersion(2)]
    public class NSFileHandleReadToEndOfFileCompletionNotification : NSNotification
    {
        public NSFileHandleReadToEndOfFileCompletionNotification() : base("", null) { }
    }
}