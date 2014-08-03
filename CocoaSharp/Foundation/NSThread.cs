using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// An NSThread object controls a thread of execution. Use this class when you want to have an Objective-C method run in its own thread of execution. Threads are especially useful when you need to perform a lengthy task, but don’t want it to block the execution of the rest of the application. In particular, you can use threads to avoid blocking the main thread of the application, which handles user interface and event-related actions.  Threads can also be used to divide a large job into several smaller jobs, which can lead to performance increases on multi-core computers.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSThread_Class/index.html#//apple_ref/occ/cl/NSThread"/>    [iOSVersion(2)]    public class NSThread : NSObject//, AnyObject, NSObjectProtocol    {        /// <summary>        /// Returns an initialized NSThread object.        /// </summary>        [iOSVersion(2)]        public NSThread() { }                /// <summary>        /// Returns an NSThread object initialized with the given arguments.        /// </summary>        /// <param name="target">The object to which the message specified by selector is sent.</param>        /// <param name="selector">The selector for the message to send to target. This selector must take only one argument and must not have a return value.</param>        /// <param name="@object">The single argument passed to the target. May be nil.</param>        [iOSVersion(2)]        [Export("convenience init")]        public NSThread(AnyObject target, Selector selector, AnyObject @object) { }                /// <summary>        /// Detaches a new thread and uses the specified selector as the thread entry point.        /// </summary>        /// <param name="aSelector">The selector for the message to send to the target. This selector must take only one argument and must not have a return value.</param>        /// <param name="toTarget">The object that will receive the message aSelector on the new thread.</param>        /// <param name="withObject">The single argument passed to the target. May be nil.</param>        [iOSVersion(2)]        [Export("detachNewThreadSelector")]        public static void DetachNewThreadSelector(Selector aSelector, AnyObject toTarget, AnyObject withObject) {  }                /// <summary>        /// Starts the receiver.        /// </summary>        [iOSVersion(2)]        [Export("start")]        public void Start() {  }                /// <summary>        /// The main entry point routine for the thread.        /// </summary>        [iOSVersion(2)]        [Export("main")]        public void Main() {  }                /// <summary>        /// Blocks the current thread until the time specified.        /// </summary>        /// <param name="aDate">The time at which to resume processing.</param>        [iOSVersion(2)]        [Export("sleepUntilDate")]        public static void SleepUntilDate(NSDate aDate) {  }                /// <summary>        /// Sleeps the thread for a given time interval.        /// </summary>        /// <param name="ti">The duration of the sleep.</param>        [iOSVersion(2)]        [Export("sleepForTimeInterval")]        public static void SleepForTimeInterval(NSTimeInterval ti) {  }                /// <summary>        /// Terminates the current thread.        /// </summary>        [iOSVersion(2)]        [Export("exit")]        public static void Exit() {  }                /// <summary>        /// Changes the cancelled state of the receiver to indicate that it should exit.        /// </summary>        [iOSVersion(2)]        [Export("cancel")]        public void Cancel() {  }                /// <summary>        /// Returns a Boolean value that indicates whether the current thread is the main thread.        /// </summary>        [iOSVersion(2)]        [Export("isMainThread")]        public static bool IsMainThread() { return default(bool); }                /// <summary>        /// Returns the NSThread object representing the main thread.        /// </summary>        [iOSVersion(2)]        [Export("mainThread")]        public static NSThread MainThread() { return default(NSThread); }                /// <summary>        /// Returns whether the application is multithreaded.        /// </summary>        [iOSVersion(2)]        [Export("isMultiThreaded")]        public static bool IsMultiThreaded() { return default(bool); }                /// <summary>        /// Returns the thread object representing the current thread of execution.        /// </summary>        [iOSVersion(2)]        [Export("currentThread")]        public static NSThread CurrentThread() { return default(NSThread); }                /// <summary>        /// Returns an array containing the call stack return addresses.        /// </summary>        [iOSVersion(2)]        [Export("callStackReturnAddresses")]        public static AnyObject[] CallStackReturnAddresses() { return default(AnyObject[]); }                /// <summary>        /// Returns an array containing the call stack symbols.        /// </summary>        [iOSVersion(4)]        [Export("callStackSymbols")]        public static AnyObject[] CallStackSymbols() { return default(AnyObject[]); }                /// <summary>        /// Returns the current thread’s priority.        /// </summary>        [iOSVersion(2)]        [Export("threadPriority")]        public static Double ThreadPriority() { return default(Double); }                /// <summary>        /// Sets the current thread’s priority.        /// </summary>        /// <param name="priority">The new priority, specified with a floating point number from 0.0 to 1.0, where 1.0 is highest priority.</param>        [iOSVersion(2)]        [Export("setThreadPriority")]        public static bool SetThreadPriority(Double priority) { return default(bool); }                /// <summary>        /// A Boolean value that indicates whether the receiver is executing. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("executing")]        public bool Executing { get; private set; }                /// <summary>        /// A Boolean value that indicates whether the receiver has finished execution. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("finished")]        public bool Finished { get; private set; }                /// <summary>        /// A Boolean value that indicates whether the receiver is cancelled. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("cancelled")]        public bool Cancelled { get; private set; }                /// <summary>        /// The thread object's dictionary. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("threadDictionary")]        public NSMutableDictionary ThreadDictionary { get; private set; }                /// <summary>        /// The name of the receiver.        /// </summary>        [iOSVersion(2)]        [Export("name")]        public string Name { get; set; }                /// <summary>        /// The stack size of the receiver, in bytes.        /// </summary>        [iOSVersion(2)]        [Export("stackSize")]        public int StackSize { get; set; }    }    /// <summary>    ///     /// </summary>    [iOSVersion(2)]    public class NSDidBecomeSingleThreadedNotification : NSNotification    {        public NSDidBecomeSingleThreadedNotification() : base("", null) { }    }    /// <summary>    /// The notification object is the exiting NSThread object. This notification does not contain a userInfo dictionary.    /// </summary>    [iOSVersion(2)]    public class NSThreadWillExitNotification : NSNotification    {        public NSThreadWillExitNotification() : base("", null) { }    }    /// <summary>    /// This notification does not contain a notification object or a userInfo dictionary.    /// </summary>    [iOSVersion(2)]    public class NSWillBecomeMultiThreadedNotification : NSNotification    {        public NSWillBecomeMultiThreadedNotification() : base("", null) { }    }}