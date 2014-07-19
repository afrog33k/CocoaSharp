using ObjectiveC;
        /// !! IMPORTANT !! Name the parameters you're using!
        /// 
        /// 
        /// Creates and returns an NSValue object that contains a given value which is interpreted as being of a given Objective-C type.
        /// <param name="objCType">The Objective-C type of value. type should be created with the Objective-C @encode() compiler directive; it should not be hard-coded as a C string.</param>
        /// <param name="value">The value for the new NSValue object.</param>
        /// <param name="withObjCType">The Objective-C type of value. type should be created with the Objective-C @encode() compiler directive; it should not be hard-coded as a C string.</param>
        /// <returns>An initialized NSValue object that contains value, which is interpreted as being of the Objective-C type type. The returned object might be different than the original receiver.</returns>
        /// <returns>A new NSValue object that contains value, which is interpreted as being of the Objective-C type type.</returns>
        public NSValue(CConstVoidPointer bytes = null, CString objCType = null, CConstVoidPointer value = null, CString withObjCType = null) { }
        public NSValue(AnyObject nonretainedObject) { }