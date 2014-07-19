using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/NSOperation_class/index.html#//apple_ref/occ/cl/NSOperation
    /// <summary>
    /// The NSOperation class is an abstract class you use to encapsulate the code and data associated with a single task. Because it is abstract, you do not use this class directly but instead subclass or use one of the system-defined subclasses (NSInvocationOperation or NSBlockOperation) to perform the actual task. Despite being abstract, the base implementation of NSOperation does include significant logic to coordinate the safe execution of your task. The presence of this built-in logic allows you to focus on the actual implementation of your task, rather than on the glue code needed to ensure it works correctly with other system objects.
    /// </summary>
    [iOSVersion(2)]
    public class NSOperation : NSObject
    {
        /// <summary>
        /// Returns an initialized NSOperation object.
        /// </summary>
        /// <returns>The initialized NSOperation object.</returns>
        [iOSVersion(2)]
        public NSOperation() { }
        
        /// <summary>
        /// Begins the execution of the operation.
        /// </summary>
        [iOSVersion(2)]
        [Export("start")]
        public void Start() { }
        
        /// <summary>
        /// Performs the receiver’s non-concurrent task.
        /// </summary>
        [iOSVersion(2)]
        [Export("main")]
        public void Main() { }
        
        /// <summary>
        /// The block to execute after the operation’s main task is completed.
        /// </summary>
        [iOSVersion(4)]
        [Export("completionBlock")]
        public Action CompletionBlock { get; set; }
        
        /// <summary>
        /// Advises the operation object that it should stop executing its task.
        /// </summary>
        [iOSVersion(2)]
        [Export("cancel")]
        public void Cancel() { }
        
        /// <summary>
        /// A Boolean value indicating whether the operation has been cancelled (read-only)
        /// </summary>
        [iOSVersion(8)]
        [Export("cancelled")]
        public bool Cancelled { get; private set; }
        
        /// <summary>
        /// A Boolean value indicating whether the operation is currently executing. (read-only)
        /// </summary>
        [iOSVersion(8)]
        [Export("executing")]
        public bool Executing { get; private set; }
        
        /// <summary>
        /// A Boolean value indicating whether the operation has finished executing its task. (read-only)
        /// </summary>
        [iOSVersion(8)]
        [Export("finished")]
        public bool Finished { get; private set; }
        
        /// <summary>
        /// A Boolean value indicating whether the operation executes its task asynchronously. (read-only)
        /// </summary>
        [iOSVersion(8)]
        [Export("concurrent")]
        public bool Concurrent { get; private set; }
        
        /// <summary>
        /// A Boolean value indicating whether the operation executes its task asynchronously. (read-only)
        /// </summary>
        [iOSVersion(7)]
        [Export("asynchronous")]
        public bool Asynchronous { get; private set; }
        
        /// <summary>
        /// A Boolean value indicating whether the operation can be performed now. (read-only)
        /// </summary>
        [iOSVersion(8)]
        [Export("ready")]
        public bool Ready { get; private set; }
        
        /// <summary>
        /// The name of the operation.
        /// </summary>
        [iOSVersion(8)]
        [Export("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// Makes the receiver dependent on the completion of the specified operation.
        /// </summary>
        /// <param name="operation">The operation on which the receiver should depend. The same dependency should not be added more than once to the receiver, and the results of doing so are undefined.</param>
        [iOSVersion(2)]
        [Export("addDependency")]
        public void AddDependency(NSOperation operation) { }
        
        /// <summary>
        /// Removes the receiver’s dependence on the specified operation.
        /// </summary>
        /// <param name="operation">The dependent operation to be removed from the receiver.</param>
        [iOSVersion(2)]
        [Export("removeDependency")]
        public void RemoveDependency(NSOperation operation) { }
        
        /// <summary>
        /// An array of the operation objects that must finish executing before the current object can begin executing. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("dependencies")]
        public AnyObject[] Dependencies { get; private set; }
        
        /// <summary>
        /// The relative amount of importance for granting system resources to the operation.
        /// </summary>
        [iOSVersion(8)]
        [Export("qualityOfService")]
        public NSQualityOfService QualityOfService { get; set; }
        
        /// <summary>
        /// The thread priority to use when executing the operation
        /// </summary>
        [iOSVersion(4)]
        [Export("threadPriority")]
        public CDouble ThreadPriority { get; set; }
        
        /// <summary>
        /// The execution priority of the operation in an operation queue.
        /// </summary>
        [iOSVersion(2)]
        [Export("queuePriority")]
        public NSOperationQueuePriority QueuePriority { get; set; }
        
        /// <summary>
        /// Blocks execution of the current thread until the operation object finishes its task.
        /// </summary>
        [iOSVersion(4)]
        [Export("waitUntilFinished")]
        public void WaitUntilFinished() { }
    }

    public enum NSQualityOfService { } //TODO: NSQualityOfService
        
    /// <summary>
    /// These constants let you prioritize the order in which operations execute.
    /// </summary>
    public enum NSOperationQueuePriority
    {
        /// <summary>
        /// Operations receive very low priority for execution.
        /// </summary>
        [iOSVersion(2)]
        VeryLow,
            
        /// <summary>
        /// Operations receive low priority for execution.
        /// </summary>
        [iOSVersion(2)]
        Low,
            
        /// <summary>
        /// Operations receive the normal priority for execution.
        /// </summary>
        [iOSVersion(2)]
        Normal,
            
        /// <summary>
        /// Operations receive high priority for execution.
        /// </summary>
        [iOSVersion(2)]
        High,
            
        /// <summary>
        /// Operations receive very high priority for execution.
        /// </summary>
        [iOSVersion(2)]
        VeryHigh,
    }
}