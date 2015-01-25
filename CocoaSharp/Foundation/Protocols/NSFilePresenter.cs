using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// The NSFilePresenter protocol should be implemented by objects that allow the user to view or edit the content of files or directories. You use file presenters in conjunction with an NSFileCoordinator object to coordinate access to a file or directory among the objects of your application and between your application and other processes. When changes to an item occur, the system notifies objects that adopt this protocol and gives them a chance to respond appropriately.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Foundation/Reference/NSFilePresenter_protocol/index.html#//apple_ref/occ/intf/NSFilePresenter"/>    [iOSVersion(5)]    [Export("")]    public interface NSFilePresenter//: NSObjectProtocol    {        /// <summary>        /// Notifies your object that another object or process wants to read the presented file or directory.        /// </summary>        /// <param name="reader">A Block object that takes another block as a parameter and returns no value. The reacquirer block is one you pass to the reader block so that your object can be notified when the reader is done. If your object does not need to be notified, it can pass nil for the reacquirer block.</param>        //[iOSVersion(5)]        //[Export("relinquishPresentedItemToReader")]        //[InheritOptional]        //void RelinquishPresentedItemToReader(Action reader);                /// <summary>        /// Notifies your object that another object or process wants to write to the presented file or directory.        /// </summary>        /// <param name="writer">A Block object that takes another block as a parameter and returns no value. The reacquirer block is one you pass to the writer block so that your object can be notified when the writer is done. If your object does not need to be notified, it can pass nil for the reacquirer block.</param>        //[iOSVersion(5)]        //[Export("relinquishPresentedItemToWriter")]        //[InheritOptional]        //void RelinquishPresentedItemToWriter(Action writer);                /// <summary>        /// Tells your object to save any unsaved changes for the presented item.        /// </summary>        /// <param name="completionHandler">The Block object to call after you save your changes. If you saved your changes successfully, pass nil for the block’s errorOrNil parameter; otherwise, pass an error object indicating why the changes could not be saved.</param>        //[iOSVersion(5)]        //[Export("savePresentedItemChangesWithCompletionHandler")]        //[InheritOptional]        //void SavePresentedItemChangesWithCompletionHandler(Action<NSError> completionHandler);                /// <summary>        /// Tells your object that its presented item is about to be deleted.        /// </summary>        /// <param name="completionHandler">The Block object to call after updating your data structures. Pass nil to the block’s errorOrNil parameter if you were able to successfully prepare for the deletion of the item. Pass an error object if your object could not prepare itself properly.</param>        //[iOSVersion(5)]        //[Export("accommodatePresentedItemDeletionWithCompletionHandler")]        //[InheritOptional]        //void AccommodatePresentedItemDeletionWithCompletionHandler(Action<NSError> completionHandler);                /// <summary>        /// Tells your object that the presented item moved or was renamed.        /// </summary>        /// <param name="newURL">The URL containing the new path to the presented item.</param>        //[iOSVersion(5)]        //[Export("presentedItemDidMoveToURL")]        //[InheritOptional]        //void PresentedItemDidMoveToURL(NSURL newURL);                /// <summary>        /// Tells your object that the presented item’s contents or attributes changed.        /// </summary>        //[iOSVersion(5)]        //[Export("presentedItemDidChange")]        //[InheritOptional]        //void PresentedItemDidChange();                /// <summary>        /// Tells the delegate that a new version of the file or file package was added. (required)        /// </summary>        /// <param name="version">The file version object containing information about the new file version.</param>        //[iOSVersion(5)]        //[Export("presentedItemDidGainVersion")]        //[InheritOptional]        //void PresentedItemDidGainVersion(NSFileVersion version);                /// <summary>        /// Tells the delegate that a version of the file or file package was removed. (required)        /// </summary>        /// <param name="version">The file version object containing information about the version that was removed.</param>        //[iOSVersion(5)]        //[Export("presentedItemDidLoseVersion")]        //[InheritOptional]        //void PresentedItemDidLoseVersion(NSFileVersion version);                /// <summary>        /// Tells the delegate that some other entity resolved a version conflict for the presenter’s file or file package. (required)        /// </summary>        /// <param name="version">The version object containing the conflicting change.</param>        //[iOSVersion(5)]        //[Export("presentedItemDidResolveConflictVersion")]        //[InheritOptional]        //void PresentedItemDidResolveConflictVersion(NSFileVersion version);                /// <summary>        /// Tells the delegate that the item inside the presented directory gained a new version. (required)        /// </summary>        /// <param name="url">The URL of the item inside the presented directory that gained a new version. The item need not be at the top level of the presented directory but may itself be inside a nested subdirectory.</param>        /// <param name="didGainVersion">The file version object containing information about the new file version.</param>        //[iOSVersion(5)]        //[Export("presentedSubitemAtURL")]        //[InheritOptional]        //void PresentedSubitemAtURL(NSURL url, NSFileVersion didGainVersion);                /// <summary>        /// Tells the delegate that the item inside the presented directory lost an existing version. (required)        /// </summary>        /// <param name="url">The URL of the item inside the presented directory that lost a version. The item need not be at the top level of the presented directory but may itself be inside a nested subdirectory.</param>        /// <param name="didLoseVersion">The file version object containing information about the version that was removed.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        //[iOSVersion(5)]        //[Export("presentedSubitemAtURL")]        //[InheritOptional]        //[IgnoreParameter("NAME_YOUR_PARAMS")]        //void PresentedSubitemAtURL(NSURL url, NSFileVersion didLoseVersion, bool NAME_YOUR_PARAMS = false);                /// <summary>        /// Tells the delegate that the item inside the presented directory had a version conflict resolved by an outside entity. (required)        /// </summary>        /// <param name="url">The URL of the item inside the presented directory that was in conflict. The item need not be at the top level of the presented directory but may itself be inside a nested subdirectory.</param>        /// <param name="didResolveConflictVersion">The version object containing the conflicting change.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        //[iOSVersion(5)]        //[Export("presentedSubitemAtURL")]        //[InheritOptional]        //[IgnoreParameter("NAME_YOUR_PARAMS")]        //void PresentedSubitemAtURL(NSURL url, NSFileVersion didResolveConflictVersion, int NAME_YOUR_PARAMS = 0);                /// <summary>        /// Tells the delegate that some entity wants to delete an item that is inside of a presented directory. (required)        /// </summary>        /// <param name="url">The URL of the item being deleted from the presented directory. The item need not be at the top level of the presented directory but may itself be inside a nested subdirectory.</param>        /// <param name="completionHandler">The Block object to call after updating your data structures. Pass nil to the block’s errorOrNil parameter if you were able to successfully prepare for the deletion of the item. Pass an error object if your object could not prepare itself properly.</param>        //[iOSVersion(5)]        //[Export("accommodatePresentedSubitemDeletionAtURL")]        //[InheritOptional]        //void AccommodatePresentedSubitemDeletionAtURL(NSURL url, Action<NSError> completionHandler);                /// <summary>        /// Tells the delegate that an item was added to the presented directory. (required)        /// </summary>        /// <param name="url">The URL of the item being added to the presented directory. The item need not be at the top level of the presented directory but may itself be inside a nested subdirectory.</param>        //[iOSVersion(5)]        //[Export("presentedSubitemDidAppearAtURL")]        //[InheritOptional]        //void PresentedSubitemDidAppearAtURL(NSURL url);                /// <summary>        /// Tells the delegate that an item in the presented directory moved to a new location. (required)        /// </summary>        /// <param name="oldURL">The original URL of the item inside the presented directory. The item need not be at the top level of the presented directory but may itself be inside a nested subdirectory.</param>        /// <param name="didMoveToURL">The new URL for the item. This URL may or may not be located inside the presented directory.</param>        //[iOSVersion(5)]        //[Export("presentedSubitemAtURL")]        //[InheritOptional]        //void PresentedSubitemAtURL(NSURL oldURL, NSURL didMoveToURL);                /// <summary>        /// Tells the delegate that the contents or attributes of the specified item changed. (required)        /// </summary>        /// <param name="url">The URL of the item in the presented directory that changed. The item need not be at the top level of the presented directory but may itself be inside a nested subdirectory.</param>        //[iOSVersion(5)]        //[Export("presentedSubitemDidChangeAtURL")]        //[InheritOptional]        //void PresentedSubitemDidChangeAtURL(NSURL url);                /// <summary>        /// The URL of the presented file or directory. (required) (read-only)        /// </summary>        [iOSVersion(5)]        [Export("presentedItemURL")]        [Optional]        NSURL PresentedItemURL { get; }                /// <summary>        /// The operation queue in which to execute presenter-related messages. (required) (read-only)        /// </summary>        [iOSVersion(5)]        [Export("presentedItemOperationQueue")]        NSOperationQueue PresentedItemOperationQueue { get; }    }}