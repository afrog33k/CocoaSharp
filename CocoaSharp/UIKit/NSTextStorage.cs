using ObjectiveC;
        public NSTextStorage() : base("") { }

    /// <summary>
    /// Posted after a text storage finishes processing edits in
    /// Observers other than the delegate shouldn’t make further changes to the text storage. The notification object is the text storage object that processed the edits. This notification does not contain a userInfo dictionary.
    /// </summary>
    [iOSVersion(7)]
    public class NSTextStorageDidProcessEditingNotification : NSNotification
    {
        public NSTextStorageDidProcessEditingNotification() : base("", null) { }
    }
    
    /// <summary>
    /// Posted before a text storage finishes processing edits in
    /// Observers other than the delegate shouldn’t make further changes to the text storage. The notification object is the text storage object that is about to process the edits. This notification does not contain a userInfo dictionary.
    /// </summary>
    [iOSVersion(7)]
    public class NSTextStorageWillProcessEditingNotification : NSNotification
    {
        public NSTextStorageWillProcessEditingNotification() : base("", null) { }
    }