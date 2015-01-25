using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// NSOrderedSet and its subclass, NSMutableOrderedSet, declare the programmatic interfaces to an ordered collection of objects.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Foundation/Reference/NSOrderedSet_Class/index.html#//apple_ref/occ/cl/NSOrderedSet"/>    [iOSVersion(5)]    [Export("")]    public class NSOrderedSet : NSObject//, AnyObject, CVarArgType, Equatable, Hashable, NSCoding, NSCopying, NSFastEnumeration, NSMutableCopying, NSObjectProtocol, NSSecureCoding, Printable    {        /// <summary>        /// Creates and returns an ordered set containing the objects from another ordered set.        /// </summary>        /// <param name="orderedSet">A set containing the objects to add to the new ordered set.        ///   The objects are not copied, simply referenced.</param>        [iOSVersion(5)]        [Export("convenience init")]        public NSOrderedSet([Optional] NSOrderedSet orderedSet) { }                /// <summary>        /// Creates and returns an ordered set with the contents of a set.        /// </summary>        /// <param name="set">A set.</param>        [iOSVersion(5)]        [Export("convenience init")]        public NSOrderedSet([Optional] NSSet set) { }                /// <summary>        /// Creates and returns an ordered set with the contents of a set, optionally copying the items.        /// </summary>        /// <param name="set">A set.</param>        /// <param name="copyItems">If true the objects are copied to the ordered set; otherwise false.</param>        [iOSVersion(5)]        [Export("convenience init")]        public NSOrderedSet([Optional] NSSet set, bool copyItems) { }                /// <summary>        /// Initializes a newly allocated set with the objects that are contained in a given array.        /// </summary>        /// <param name="array">An array of objects to add to the new set.        ///   If the same object appears more than once in array, it is represented only once in the returned ordered set.</param>        [iOSVersion(5)]        [Export("convenience init")]        public NSOrderedSet(AnyObject[] array) { }                /// <summary>        /// Initializes a newly allocated set with the objects that are contained in a given array, optionally copying the items.        /// </summary>        /// <param name="array">An array of objects to add to the new set.        ///   If the same object appears more than once in array, it is represented only once in the returned ordered set.</param>        /// <param name="copyItems">If true the objects are copied to the ordered set; otherwise false.</param>        [iOSVersion(5)]        [Export("convenience init")]        public NSOrderedSet(AnyObject[] array, bool copyItems) { }                /// <summary>        /// Initializes a newly allocated set with the objects that are contained in the specified range of an array, optionally copying the items.        /// </summary>        /// <param name="array">An array of objects to add to the new set.        ///   If the same object appears more than once in array, it is represented only once in the returned ordered set.</param>        /// <param name="range">The range of objects in array to add to the ordered set.</param>        /// <param name="copyItems">If true the objects are copied to the ordered set; otherwise false.</param>        [iOSVersion(5)]        [Export("convenience init")]        public NSOrderedSet(AnyObject[] array, NSRange range, bool copyItems) { }                /// <summary>        /// Initializes a new ordered set with the object.        /// </summary>        /// <param name="@object">The object to add to the new ordered set</param>        [iOSVersion(5)]        [Export("convenience init")]        public NSOrderedSet(AnyObject @object) { }                /// <summary>        /// Initializes a newly allocated set with a specified number of objects from a given C array of objects.        /// </summary>        /// <param name="objects">A C array of objects to add to the new set.        ///   If the same object appears more than once in objects, it is added only once to the returned ordered set.</param>        /// <param name="count">The number of objects from objects to add to the new ordered set.</param>        [iOSVersion(5)]        public NSOrderedSet(UnsafePointer<AnyObject> objects, int count) { }                /// <summary>        /// Initializes a new ordered set with the contents of a set.        /// </summary>        /// <param name="orderedSet">A set.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(5)]        [Export("convenience init")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        public NSOrderedSet(NSOrderedSet orderedSet, uint NAME_YOUR_PARAMS = 14) { }                /// <summary>        /// Initializes a new ordered set with the contents of a set, optionally copying the items.        /// </summary>        /// <param name="orderedSet">A set.</param>        /// <param name="copyItems">If true the objects are copied to the ordered set; otherwise false.</param>        [iOSVersion(5)]        [Export("convenience init")]        public NSOrderedSet(NSOrderedSet orderedSet, bool copyItems) { }                /// <summary>        /// Initializes a new ordered set with the contents of an ordered set, optionally copying the items.        /// </summary>        /// <param name="orderedSet">An ordered set.</param>        /// <param name="range">The range of objects in orderedSet to add to the ordered set.</param>        /// <param name="copyItems">If true the objects are copied to the ordered set; otherwise false.</param>        [iOSVersion(5)]        [Export("convenience init")]        public NSOrderedSet(NSOrderedSet orderedSet, NSRange range, bool copyItems) { }                /// <summary>        /// Initializes a new ordered set with the contents of a set.        /// </summary>        /// <param name="set">The set.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(5)]        [Export("convenience init")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        public NSOrderedSet(NSSet set, short NAME_YOUR_PARAMS = 1) { }                /// <summary>        /// Initializes a new ordered set with the contents of a set, optionally copying the objects in the set.        /// </summary>        /// <param name="set">The set.</param>        /// <param name="copyItems">If true the objects are copied to the ordered set; otherwise false.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(5)]        [Export("convenience init")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        public NSOrderedSet(NSSet set, bool copyItems, bool NAME_YOUR_PARAMS = false) { }                /// <summary>        /// Initializes a newly allocated ordered set.        /// </summary>        [iOSVersion(7)]        public NSOrderedSet() { }                /// <summary>        /// Returns a Boolean value that indicates whether a given object is present in the ordered set.        /// </summary>        /// <param name="@object">The object for which to test membership of the ordered set.</param>        [iOSVersion(5)]        [Export("containsObject")]        public virtual bool ContainsObject(AnyObject @object) { return default(bool); }                /// <summary>        /// Executes a given block using the objects in the ordered set at the specified indexes.        /// </summary>        /// <param name="indexSet">The indexes of the objects over which to enumerate.</param>        /// <param name="options">A bitmask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>        /// <param name="usingBlock">The block to apply to elements in the ordered set.        ///   The block takes three arguments:        ///       obj        ///   The element in the ordered set.        ///       idx        ///   The index of the element in the ordered set.        ///       stop        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the block.</param>        [iOSVersion(5)]        [Export("enumerateObjectsAtIndexes")]        public virtual void EnumerateObjectsAtIndexes(NSIndexSet indexSet, NSEnumerationOptions options, Action<AnyObject, int, UnsafeMutablePointer<ObjCBool>> usingBlock) {  }                /// <summary>        /// Executes a given block using each object in the ordered set.        /// </summary>        /// <param name="block">The block to apply to elements in the ordered set.        ///   The block takes three arguments:        ///       idx        ///   The element in the set.        ///       idx        ///   The index of the item in the set.        ///       stop        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this value to true within the block.        ///   The block returns a Boolean value that indicates whether obj passed the test.</param>        [iOSVersion(5)]        [Export("enumerateObjectsUsingBlock")]        public virtual void EnumerateObjectsUsingBlock(Action<AnyObject, int, UnsafeMutablePointer<ObjCBool>> block) {  }                /// <summary>        /// Executes a given block using each object in the set, using the specified enumeration options.        /// </summary>        /// <param name="opts">A bitmask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>        /// <param name="usingBlock">The block to apply to elements in the ordered set.        ///   The block takes three arguments:        ///       obj        ///   The element in the set.        ///       idx        ///   The index of the item in the set.        ///       stop        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this value to true within the block.        ///   The block returns a Boolean value that indicates whether obj passed the test.</param>        [iOSVersion(5)]        [Export("enumerateObjectsWithOptions")]        public virtual void EnumerateObjectsWithOptions(NSEnumerationOptions opts, Action<AnyObject, int, UnsafeMutablePointer<ObjCBool>> usingBlock) {  }                /// <summary>        /// Returns the object at the specified index of the set.        /// </summary>        /// <param name="index">The object located at index.</param>        [iOSVersion(5)]        [Export("objectAtIndex")]        public virtual AnyObject ObjectAtIndex(int index) { return default(AnyObject); }                /// <summary>        /// Returns the objects in the ordered set at the specified indexes.        /// </summary>        /// <param name="indexes">The indexes.</param>        [iOSVersion(5)]        [Export("objectsAtIndexes")]        public virtual AnyObject[] ObjectsAtIndexes(NSIndexSet indexes) { return default(AnyObject[]); }                /// <summary>        /// Returns the index of the specified object.        /// </summary>        /// <param name="@object">The object.</param>        [iOSVersion(5)]        [Export("indexOfObject")]        public virtual int IndexOfObject(AnyObject @object) { return default(int); }                /// <summary>        /// Returns the index, within a specified range, of an object compared with elements in the ordered set using a given NSComparator block.        /// </summary>        /// <param name="@object">An object for which to search in the ordered set.        ///   If this value is nil, throws an NSInvalidArgumentException.</param>        /// <param name="inSortedRange">The range within the array to search for object.        ///   If r exceeds the bounds of the ordered set (if the location plus length of the range is greater than the count of the ordered set), throws an NSRangeException.</param>        /// <param name="options">Options for the search. For possible values, see NSBinarySearchingOptions.</param>        /// <param name="usingComparator">A comparator block used to compare the object obj with elements in the ordered set.        ///   If this value is NULL, throws an NSInvalidArgumentException.</param>        [iOSVersion(5)]        [Export("indexOfObject")]        public virtual int IndexOfObject(AnyObject @object, NSRange inSortedRange, NSBinarySearchingOptions options, NSComparator usingComparator) { return default(int); }                /// <summary>        /// Returns the index, from a given set of indexes, of the object in the ordered set that passes a test in a given block for a given set of enumeration options.        /// </summary>        /// <param name="indexSet">The indexes of the objects over which to enumerate.</param>        /// <param name="options">A bitmask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>        /// <param name="passingTest">The block to apply to elements in the ordered set.        ///   The block takes three arguments:        ///       obj        ///   The element in the ordered set.        ///       idx        ///   The index of the element in the ordered set.        ///       stop        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this value to true within the block.        ///   The block returns a Boolean value that indicates whether obj passed the test.</param>        [iOSVersion(5)]        [Export("indexOfObjectAtIndexes")]        public virtual int IndexOfObjectAtIndexes(NSIndexSet indexSet, NSEnumerationOptions options, Func<AnyObject, int, UnsafeMutablePointer<ObjCBool>, bool> passingTest) { return default(int); }                /// <summary>        /// Returns the index of the object in the ordered set that passes a test in a given block.        /// </summary>        /// <param name="predicate">The block to apply to elements in the ordered set.        ///   The block takes three arguments:        ///       obj        ///   The element in the ordered set.        ///       Term        ///   The index of the element in the ordered set.        ///       stop        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this value to true within the block.</param>        [iOSVersion(5)]        [Export("indexOfObjectPassingTest")]        public virtual int IndexOfObjectPassingTest(Func<AnyObject, int, UnsafeMutablePointer<ObjCBool>, bool> predicate) { return default(int); }                /// <summary>        /// Returns the index of an object in the ordered set that passes a test in a given block for a given set of enumeration options.        /// </summary>        /// <param name="opts">A bitmask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>        /// <param name="passingTest">The block to apply to elements in the ordered set.        ///   The block takes three arguments:        ///       obj        ///   The element in the array.        ///       idx        ///   The index of the element in the ordered set.        ///       stop        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this value to true within the block.        ///   The block returns a Boolean value that indicates whether obj passed the test.</param>        [iOSVersion(5)]        [Export("indexOfObjectWithOptions")]        public virtual int IndexOfObjectWithOptions(NSEnumerationOptions opts, Func<AnyObject, int, UnsafeMutablePointer<ObjCBool>, bool> passingTest) { return default(int); }                /// <summary>        /// Returns the index, from a given set of indexes, of the object in the ordered set that passes a test in a given block for a given set of enumeration options.        /// </summary>        /// <param name="indexSet">The indexes of the objects over which to enumerate.</param>        /// <param name="options">A bitmask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>        /// <param name="passingTest">The block to apply to elements in the ordered set.        ///   The block takes three arguments:        ///       obj        ///   The element in the ordered set.        ///       idx        ///   The index of the element in the ordered set.        ///       stop        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this value to true within the block.        ///   The block returns a Boolean value that indicates whether obj passed the test.</param>        [iOSVersion(5)]        [Export("indexesOfObjectsAtIndexes")]        public virtual NSIndexSet IndexesOfObjectsAtIndexes(NSIndexSet indexSet, NSEnumerationOptions options, Func<AnyObject, int, UnsafeMutablePointer<ObjCBool>, bool> passingTest) { return default(NSIndexSet); }                /// <summary>        /// Returns the index of the object in the ordered set that passes a test in a given block.        /// </summary>        /// <param name="predicate">The block to apply to elements in the ordered set.        ///   The block takes three arguments:        ///       obj        ///   The element in the ordered set.        ///       Term        ///   The index of the element in the ordered set.        ///       stop        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this value to true within the block.</param>        [iOSVersion(5)]        [Export("indexesOfObjectsPassingTest")]        public virtual NSIndexSet IndexesOfObjectsPassingTest(Func<AnyObject, int, UnsafeMutablePointer<ObjCBool>, bool> predicate) { return default(NSIndexSet); }                /// <summary>        /// Returns the index of an object in the ordered set that passes a test in a given block for a given set of enumeration options.        /// </summary>        /// <param name="opts">A bitmask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>        /// <param name="passingTest">The block to apply to elements in the ordered set.        ///   The block takes three arguments:        ///       obj        ///   The element in the ordered set.        ///       Term        ///   The index of the element in the ordered set.        ///       stop        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this value to true within the block.</param>        [iOSVersion(5)]        [Export("indexesOfObjectsWithOptions")]        public virtual NSIndexSet IndexesOfObjectsWithOptions(NSEnumerationOptions opts, Func<AnyObject, int, UnsafeMutablePointer<ObjCBool>, bool> passingTest) { return default(NSIndexSet); }                /// <summary>        /// Returns an enumerator object that lets you access each object in the ordered set.        /// </summary>        [iOSVersion(5)]        [Export("objectEnumerator")]        public virtual NSEnumerator ObjectEnumerator() { return default(NSEnumerator); }                /// <summary>        /// Returns an enumerator object that lets you access each object in the ordered set.        /// </summary>        [iOSVersion(5)]        [Export("reverseObjectEnumerator")]        public virtual NSEnumerator ReverseObjectEnumerator() { return default(NSEnumerator); }                /// <summary>        /// Copies the objects contained in the ordered set that fall within the specified range to objects.        /// </summary>        /// <param name="objects">A C array of objects of size at least the length of the range specified by aRange.</param>        /// <param name="range">A range within the bounds of the array.        ///   If the location plus the length of the range is greater than the count of the array, this method raises an NSRangeException.</param>        [iOSVersion(5)]        [Export("getObjects")]        public virtual void GetObjects(AutoreleasingUnsafeMutablePointer<AnyObject> objects, NSRange range) {  }                /// <summary>        /// Invokes setValue:forKey: on each of the receiver&#39;s members using the specified value and key        /// </summary>        /// <param name="value">The object value.</param>        /// <param name="forKey">The key to store the value.</param>        [iOSVersion(5)]        [Export("setValue")]        public virtual void SetValue([Optional] AnyObject value, string forKey) {  }                /// <summary>        /// Returns an ordered set containing the results of invoking valueForKey: using key on each of the ordered set’s objects.        /// </summary>        /// <param name="key">The key to retrieve.</param>        [iOSVersion(5)]        [Export("valueForKey")]        public virtual AnyObject ValueForKey(string key) { return default(AnyObject); }                /// <summary>        /// Raises an exception.        /// </summary>        /// <param name="observer">The object to register for KVO notifications.</param>        /// <param name="forKeyPath">The key path, relative to the array, of the property to observe. This value must not be nil.</param>        /// <param name="options">A combination of NSKeyValueObservingOptions values that specifies what is included in observation notifications.</param>        /// <param name="context">Arbitrary data that is passed to observer in observeValueForKeyPath:ofObject:change:context:.</param>        [iOSVersion(5)]        [Export("addObserver")]        public virtual void AddObserver(NSObject observer, string forKeyPath, NSKeyValueObservingOptions options, UnsafeMutablePointer context) {  }                /// <summary>        /// Raises an exception.        /// </summary>        /// <param name="observer">The object to remove as an observer.</param>        /// <param name="forKeyPath">A key-path, relative to the set, for which observer is registered to receive KVO change notifications. This value must not be nil.</param>        [iOSVersion(5)]        [Export("removeObserver")]        public virtual void RemoveObserver(NSObject observer, string forKeyPath) {  }                /// <summary>        /// Raises an exception.        /// </summary>        /// <param name="observer">The object to remove as an observer.</param>        /// <param name="forKeyPath">A key-path, relative to the set, for which observer is registered to receive KVO change notifications. This value must not be nil.</param>        /// <param name="context">The context passed to the notifications.</param>        [iOSVersion(5)]        [Export("removeObserver")]        public virtual void RemoveObserver(NSObject observer, string forKeyPath, UnsafeMutablePointer context) {  }                /// <summary>        /// Compares the receiving ordered set to another ordered set.        /// </summary>        /// <param name="other">The ordered set with which to compare the receiving ordered set.</param>        [iOSVersion(5)]        [Export("isEqualToOrderedSet")]        public virtual bool IsEqualToOrderedSet(NSOrderedSet other) { return default(bool); }                /// <summary>        /// Returns a Boolean value that indicates whether at least one object in the receiving ordered set is also present in another given ordered set.        /// </summary>        /// <param name="other">The other ordered set.</param>        [iOSVersion(5)]        [Export("intersectsOrderedSet")]        public virtual bool IntersectsOrderedSet(NSOrderedSet other) { return default(bool); }                /// <summary>        /// Returns a Boolean value that indicates whether at least one object in the receiving ordered set is also present in another given set.        /// </summary>        /// <param name="set">The set.</param>        [iOSVersion(5)]        [Export("intersectsSet")]        public virtual bool IntersectsSet(NSSet set) { return default(bool); }                /// <summary>        /// Returns a Boolean value that indicates whether every object in the receiving ordered set is also present in another given ordered set.        /// </summary>        /// <param name="other">The ordered set with which to compare the receiving ordered set.</param>        [iOSVersion(5)]        [Export("isSubsetOfOrderedSet")]        public virtual bool IsSubsetOfOrderedSet(NSOrderedSet other) { return default(bool); }                /// <summary>        /// Returns a Boolean value that indicates whether every object in the receiving ordered set is also present in another given set.        /// </summary>        /// <param name="set">The set with which to compare the receiving ordered set.</param>        [iOSVersion(5)]        [Export("isSubsetOfSet")]        public virtual bool IsSubsetOfSet(NSSet set) { return default(bool); }                /// <summary>        /// Returns an array of the ordered set’s elements sorted as specified by a given array of sort descriptors.        /// </summary>        /// <param name="sortDescriptors">An array of NSSortDescriptor objects.</param>        [iOSVersion(5)]        [Export("sortedArrayUsingDescriptors")]        public virtual AnyObject[] SortedArrayUsingDescriptors(AnyObject[] sortDescriptors) { return default(AnyObject[]); }                /// <summary>        /// Returns an array that lists the receiving ordered set’s elements in ascending order, as determined by the comparison method specified by a given NSComparator block        /// </summary>        /// <param name="cmptr">A comparator block.</param>        [iOSVersion(5)]        [Export("sortedArrayUsingComparator")]        public virtual AnyObject[] SortedArrayUsingComparator(NSComparator cmptr) { return default(AnyObject[]); }                /// <summary>        /// Returns an array that lists the receiving ordered set’s elements in ascending order, as determined by the comparison method specified by a given NSComparator block.        /// </summary>        /// <param name="opts">A bitmask that specifies the options for the sort (whether it should be performed concurrently and whether it should be performed stably).</param>        /// <param name="usingComparator">A comparator block.</param>        [iOSVersion(5)]        [Export("sortedArrayWithOptions")]        public virtual AnyObject[] SortedArrayWithOptions(NSSortOptions opts, NSComparator usingComparator) { return default(AnyObject[]); }                /// <summary>        /// Evaluates a given predicate against each object in the receiving ordered set and returns a new ordered set containing the objects for which the predicate returns true.        /// </summary>        /// <param name="predicate">The predicate against which to evaluate the receiving ordered set’s elements.</param>        [iOSVersion(5)]        [Export("filteredOrderedSetUsingPredicate")]        public virtual NSOrderedSet FilteredOrderedSetUsingPredicate(NSPredicate predicate) { return default(NSOrderedSet); }                /// <summary>        /// Returns a string that represents the contents of the ordered set, formatted as a property list.        /// </summary>        /// <param name="locale">An NSLocale object or an NSDictionary object that specifies options used for formatting each of the ordered set’s elements (where recognized). Specify nil if you don’t want the elements formatted.</param>        [iOSVersion(5)]        [Export("descriptionWithLocale")]        [return:Optional]        public virtual string DescriptionWithLocale([Optional] AnyObject locale) { return default(string); }                /// <summary>        /// Returns a string that represents the contents of the ordered set, formatted as a property list.        /// </summary>        /// <param name="locale">An NSLocale object or an NSDictionary object that specifies options used for formatting each of the array’s elements (where recognized). Specify nil if you don’t want the elements formatted.</param>        /// <param name="indent">Specifies a level of indentation, to make the output more readable: the indentation is (4 spaces) * level.</param>        [iOSVersion(5)]        [Export("descriptionWithLocale")]        public virtual string DescriptionWithLocale([Optional] AnyObject locale, int indent) { return default(string); }                /// <summary>        /// The number of members in the set. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("count")]        public int Count { get; private set; }                /// <summary>        /// The first object in the ordered set. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("firstObject")]        [Optional]        public AnyObject FirstObject { get; private set; }                /// <summary>        /// The last object in the ordered set. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("lastObject")]        [Optional]        public AnyObject LastObject { get; private set; }                /// <summary>        /// An ordered set in the reverse order. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("reversedOrderedSet")]        public NSOrderedSet ReversedOrderedSet { get; private set; }                /// <summary>        /// A string that represents the contents of the ordered set, formatted as a property list. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("description")]        public string Description { get; private set; }                /// <summary>        /// A representation of the ordered set as an array. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("array")]        public AnyObject[] Array { get; private set; }                /// <summary>        /// A representation of the set containing the contents of the ordered set. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("set")]        public NSSet Set { get; private set; }    }}