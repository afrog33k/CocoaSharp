using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSNotificationQueue_Class/index.html#//apple_ref/occ/cl/NSNotificationQueue
    /// <summary>
    /// NSNotificationQueue objects (or simply notification queues) act as buffers for notification centers (instances of NSNotificationCenter). Whereas a notification center distributes notifications when posted, notifications placed into the queue can be delayed until the end of the current pass through the run loop or until the run loop is idle. Duplicate notifications can also be coalesced so that only one notification is sent although multiple notifications are posted. A notification queue maintains notifications (instances of NSNotification) generally in a first in first out (FIFO) order. When a notification rises to the front of the queue, the queue posts it to the notification center, which in turn dispatches the notification to all objects registered as observers.
    /// </summary>
    [iOSVersion(2)]
    public class NSNotificationQueue : NSObject
    {
        /// <summary>
        /// Initializes and returns a notification queue for the specified notification center.
        /// </summary>
        /// <param name="notificationCenter">The notification center used by the new notification queue.</param>
        /// <returns>The newly initialized notification queue.</returns>
        [iOSVersion(2)]
        public NSNotificationQueue(NSNotificationCenter notificationCenter) { }
        
        /// <summary>
        /// Returns the default notification queue for the current thread.
        /// </summary>
        /// <returns>Returns the default notification queue for the current thread. This notification queue uses the default notification center.</returns>
        [iOSVersion(2)]
        [Export("defaultQueue")]
        public static NSNotificationQueue DefaultQueue() { return null; }
        
        /// <summary>
        /// Adds a notification to the notification queue with a specified posting style.
        /// </summary>
        /// <param name="notification">The notification to add to the queue.</param>
        /// <param name="postingStyle">The posting style for the notification. The posting style indicates when the notification queue should post the notification to its notification center.</param>
        [iOSVersion(2)]
        [Export("enqueueNotification")]
        public void EnqueueNotification(NSNotification notification, NSPostingStyle postingStyle) { }
        
        /// <summary>
        /// Adds a notification to the notification queue with a specified posting style, criteria for coalescing, and runloop mode.
        /// </summary>
        /// <param name="notification">The notification to add to the queue.</param>
        /// <param name="postingStyle">The posting style for the notification. The posting style indicates when the notification queue should post the notification to its notification center.</param>
        /// <param name="coalesceMask">A mask indicating what criteria to use when matching attributes of notification to attributes of notifications in the queue. The mask is created by combining any of the constants NSNotificationNoCoalescing, NSNotificationCoalescingOnName, and NSNotificationCoalescingOnSender.</param>
        /// <param name="forModes">The list of modes the notification may be posted in. The notification queue will only post the notification to its notification center if the run loop is in one of the modes provided in the array. May be nil, in which case it defaults to NSDefaultRunLoopMode.</param>
        [iOSVersion(2)]
        [Export("enqueueNotification")]
        public void EnqueueNotification(NSNotification notification, NSPostingStyle postingStyle, int coalesceMask, AnyObject[] forModes) { }
        
        /// <summary>
        /// Removes all notifications from the queue that match a provided notification using provided matching criteria.
        /// </summary>
        /// <param name="notification">The notification used for matching notifications to remove from the notification queue.</param>
        /// <param name="coalesceMask">A mask indicating what criteria to use when matching attributes of notification to attributes of notifications in the queue. The mask is created by combining any of the constants NSNotificationNoCoalescing, NSNotificationCoalescingOnName, and NSNotificationCoalescingOnSender.</param>
        [iOSVersion(2)]
        [Export("dequeueNotificationsMatching")]
        public void DequeueNotificationsMatching(NSNotification notification, int coalesceMask) { }
    }

    /// <summary>
    /// These constants specify how notifications are coalesced.
    /// </summary>
    [iOSVersion(2)]
    public enum NSNotificationCoalescing
    {
        /// <summary>
        /// Do not coalesce notifications in the queue.
        /// </summary>
        [iOSVersion(2)]
        NoCoalescing,

        /// <summary>
        /// Coalesce notifications with the same name.
        /// </summary>
        [iOSVersion(2)]
        CoalescingOnName,

        /// <summary>
        /// Coalesce notifications with the same object.
        /// </summary>
        [iOSVersion(2)]
        CoalescingOnSender
    }

    /// <summary>
    /// These constants specify when notifications are posted.
    /// </summary>
    [iOSVersion(2)]
    public enum NSPostingStyle
    {
        /// <summary>
        /// The notification is posted when the run loop is idle.
        /// </summary>
        [iOSVersion(2)]
        PostWhenIdle,
        
        /// <summary>
        /// The notification is posted at the end of the current notification callout or timer.
        /// </summary>
        [iOSVersion(2)]
        PostASAP,
        
        /// <summary>
        /// The notification is posted immediately after coalescing.
        /// </summary>
        [iOSVersion(2)]
        PostNow
    }
}