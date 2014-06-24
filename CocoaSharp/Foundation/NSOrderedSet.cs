using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Foundation/Reference/NSOrderedSet_Class/index.html#//apple_ref/occ/cl/NSOrderedSet
    /// <summary>
    /// NSOrderedSet and its subclass, NSMutableOrderedSet, declare the programmatic interfaces to an ordered collection of objects.
    /// </summary>
    [iOSVersion(5)]
    public class NSOrderedSet : NSObject
    {
        /// <summary>
        /// Initializes a newly allocated set with the objects that are contained in a given array.
        /// </summary>
        /// <param name="array">An array of objects to add to the new set.   If the same object appears more than once in array, it is represented only once in the returned ordered set.</param>
        /// <returns>An initialized ordered set with the contents of array. The returned ordered set might be different than the original receiver.</returns>
        [iOSVersion(5)]
        public NSOrderedSet(AnyObject[] array) { }
        
        /// <summary>
        /// Initializes a newly allocated set with the objects that are contained in a given array, optionally copying the items.
        /// </summary>
        /// <param name="array">An array of objects to add to the new set.   If the same object appears more than once in array, it is represented only once in the returned ordered set.</param>
        /// <param name="copyItems">If true the objects are copied to the ordered set; otherwise false.</param>
        /// <returns>An initialized ordered set containing a uniqued collection of the objects contained in the array.</returns>
        [iOSVersion(5)]
        public NSOrderedSet(AnyObject[] array, bool copyItems) { }
        
        /// <summary>
        /// Initializes a newly allocated set with the objects that are contained in the specified range of an array, optionally copying the items.
        /// </summary>
        /// <param name="array">An array of objects to add to the new set.   If the same object appears more than once in array, it is represented only once in the returned ordered set.</param>
        /// <param name="range">The range of objects in array to add to the ordered set.</param>
        /// <param name="copyItems">If true the objects are copied to the ordered set; otherwise false.</param>
        /// <returns>An initialized ordered set containing a uniqued collection of the objects contained in specified range of the the array.</returns>
        [iOSVersion(5)]
        public NSOrderedSet(AnyObject[] array, NSRange range, bool copyItems) { }
        
        /// <summary>
        /// Initializes a new ordered set with the object.
        /// </summary>
        /// <param name="object">The object to add to the new ordered set</param>
        /// <returns>A new ordered set that contains a single member, object.</returns>
        [iOSVersion(5)]
        public NSOrderedSet(AnyObject @object) { }
        
        /// <summary>
        /// Initializes a newly allocated set with a specified number of objects from a given C array of objects.
        /// </summary>
        /// <param name="objects">A C array of objects to add to the new set.   If the same object appears more than once in objects, it is added only once to the returned ordered set.</param>
        /// <param name="count">The number of objects from objects to add to the new ordered set.</param>
        /// <returns>An initialized ordered set containing cnt objects from the list of objects specified by objects. The returned set might be different than the original receiver.</returns>
        [iOSVersion(5)]
        public NSOrderedSet(CConstPointer<AnyObject> objects, int count) { }
        
        /// <summary>
        /// Initializes a new ordered set with the contents of a set.
        /// </summary>
        /// <param name="orderedSet">A set.</param>
        /// <returns>An initialized ordered set containing references to the objects in the set.</returns>
        [iOSVersion(5)]
        public NSOrderedSet(NSOrderedSet orderedSet) { }
        
        /// <summary>
        /// Initializes a new ordered set with the contents of a set, optionally copying the items.
        /// </summary>
        /// <param name="orderedSet">A set.</param>
        /// <param name="copyItems">If true the objects are copied to the ordered set; otherwise false.</param>
        /// <returns>An initialized ordered set containing the objects in the set.</returns>
        [iOSVersion(5)]
        public NSOrderedSet(NSOrderedSet orderedSet, bool copyItems) { }
        
        /// <summary>
        /// Initializes a new ordered set with the contents of an ordered set, optionally copying the items.
        /// </summary>
        /// <param name="orderedSet">An ordered set.</param>
        /// <param name="range">The range of objects in orderedSet to add to the ordered set.</param>
        /// <param name="copyItems">If true the objects are copied to the ordered set; otherwise false.</param>
        /// <returns>An initialized ordered set containing the objects in the ordered set.</returns>
        [iOSVersion(5)]
        public NSOrderedSet(NSOrderedSet orderedSet, NSRange range, bool copyItems) { }
        
        /// <summary>
        /// Initializes a new ordered set with the contents of a set.
        /// </summary>
        /// <param name="set">The set.</param>
        /// <returns>An initialized ordered set containing the objects in the set.</returns>
        [iOSVersion(5)]
        public NSOrderedSet(NSSet set) { }
        
        /// <summary>
        /// Initializes a new ordered set with the contents of a set, optionally copying the objects in the set.
        /// </summary>
        /// <param name="set">The set.</param>
        /// <param name="copyItems">If true the objects are copied to the ordered set; otherwise false.</param>
        /// <returns>An initialized ordered set containing the objects in the set.</returns>
        [iOSVersion(5)]
        public NSOrderedSet(NSSet set, bool copyItems) { }
        
        /// <summary>
        /// Initializes a newly allocated ordered set.
        /// </summary>
        /// <returns>An ordered set.</returns>
        [iOSVersion(7)]
        public NSOrderedSet() { }
        
        /// <summary>
        /// Returns the number of members in the set.
        /// </summary>
        /// <returns>The number of members in the set.</returns>
        [iOSVersion(5)]
        [Export("count")]
        public int Count { get; private set; }
        
        /// <summary>
        /// Returns a Boolean value that indicates whether a given object is present in the ordered set.
        /// </summary>
        /// <param name="object">The object for which to test membership of the ordered set.</param>
        /// <returns>YES if object is present in the set, otherwise false.</returns>
        [iOSVersion(5)]
        [Export("containsObject")]
        public bool ContainsObject(AnyObject @object) { return false; }
        
        /// <summary>
        /// Executes a given block using the objects in the ordered set at the specified indexes.
        /// </summary>
        /// <param name="indexSet">The indexes of the objects over which to enumerate.</param>
        /// <param name="options">A bitmask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>
        /// <param name="usingBlock">The block to apply to elements in the ordered set.   The block takes three arguments:           obj              The element in the ordered set.                idx              The index of the element in the ordered set.                stop              A reference to a Boolean value. The block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the block.</param>
        [iOSVersion(5)]
        [Export("enumerateObjectsAtIndexes")]
        public void EnumerateObjectsAtIndexes(NSIndexSet indexSet, NSEnumerationOptions options, Action<AnyObject, int, CMutablePointer<ObjCBool>> usingBlock) { }
        
        /// <summary>
        /// Executes a given block using each object in the ordered set.
        /// </summary>
        /// <param name="block">The block to apply to elements in the ordered set.   The block takes three arguments:           idx              The element in the set.                idx              The index of the item in the set.                stop              A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this value to true within the block.        The block returns a Boolean value that indicates whether obj passed the test.</param>
        [iOSVersion(5)]
        [Export("enumerateObjectsUsingBlock")]
        public void EnumerateObjectsUsingBlock(Action<AnyObject, int, CMutablePointer<ObjCBool>> block) { }
        
        /// <summary>
        /// Executes a given block using each object in the set, using the specified enumeration options.
        /// </summary>
        /// <param name="opts">A bitmask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>
        /// <param name="usingBlock">The block to apply to elements in the ordered set.   The block takes three arguments:           obj              The element in the set.                idx              The index of the item in the set.                stop              A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this value to true within the block.        The block returns a Boolean value that indicates whether obj passed the test.</param>
        [iOSVersion(5)]
        [Export("enumerateObjectsWithOptions")]
        public void EnumerateObjectsWithOptions(NSEnumerationOptions opts, Action<AnyObject, int, CMutablePointer<ObjCBool>> usingBlock) { }
        
        /// <summary>
        /// Returns the first object in the ordered set.
        /// </summary>
        /// <returns>The first object in the ordered set.</returns>
        [iOSVersion(5)]
        [Export("firstObject")]
        public AnyObject FirstObject { get; private set; }
        
        /// <summary>
        /// Returns the last object in the ordered set.
        /// </summary>
        /// <returns>The last object in the ordered set.</returns>
        [iOSVersion(5)]
        [Export("lastObject")]
        public AnyObject LastObject { get; private set; }
        
        /// <summary>
        /// Returns the object at the specified index of the set.
        /// </summary>
        /// <param name="index">The object located at index.</param>
        /// <returns>If index is beyond the end of the ordered set (that is, if index is greater than or equal to the value returned by count), an NSRangeException is raised.</returns>
        [iOSVersion(5)]
        [Export("objectAtIndex")]
        public AnyObject ObjectAtIndex(int index) { return null; }
        
        /// <summary>
        /// Returns the object at the specified index of the set.
        /// </summary>
        /// <param name="index">The object located at index.</param>
        /// <returns>If index is beyond the end of the ordered set (that is, if index is greater than or equal to the value returned by count), an NSRangeException is raised.</returns>
        [iOSVersion(6)]
        [Export("objectAtIndexedSubscript")]
        public AnyObject ObjectAtIndexedSubscript(int index) { return null; }
        
        /// <summary>
        /// Returns the objects in the ordered set at the specified indexes.
        /// </summary>
        /// <param name="indexes">The indexes.</param>
        /// <returns>The returned objects are in the ascending order of their indexes in indexes, so that object in returned ordered set with higher index in indexes will follow the object with smaller index in indexes.</returns>
        [iOSVersion(5)]
        [Export("objectsAtIndexes")]
        public AnyObject[] ObjectsAtIndexes(NSIndexSet indexes) { return null; }
        
        /// <summary>
        /// Returns the index of the specified object.
        /// </summary>
        /// <param name="object">The object.</param>
        /// <returns>The index whose corresponding ordered set value is equal to object. If none of the objects in the ordered set is equal to object, returns NSNotFound.</returns>
        [iOSVersion(5)]
        [Export("indexOfObject")]
        public int IndexOfObject(AnyObject @object) { return 0; }
        
        /// <summary>
        /// Returns the index, within a specified range, of an object compared with elements in the ordered set using a given NSComparator block.
        /// </summary>
        /// <param name="object">An object for which to search in the ordered set.   If this value is nil, throws an NSInvalidArgumentException.</param>
        /// <param name="inSortedRange">The range within the array to search for object.   If r exceeds the bounds of the ordered set (if the location plus length of the range is greater than the count of the ordered set), throws an NSRangeException.</param>
        /// <param name="options">Options for the search. For possible values, see NSBinarySearchingOptions.</param>
        /// <param name="usingComparator">A comparator block used to compare the object obj with elements in the ordered set.   If this value is NULL, throws an NSInvalidArgumentException.</param>
        /// <returns>If the NSBinarySearchingInsertionIndex option is not specified:</returns>
        [iOSVersion(5)]
        [Export("indexOfObject")]
        public int IndexOfObject(AnyObject @object, NSRange inSortedRange, NSBinarySearchingOptions options, NSComparator usingComparator) { return 0; }
        
        /// <summary>
        /// Returns the index, from a given set of indexes, of the object in the ordered set that passes a test in a given block for a given set of enumeration options.
        /// </summary>
        /// <param name="indexSet">The indexes of the objects over which to enumerate.</param>
        /// <param name="options">A bitmask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>
        /// <param name="passingTest">The block to apply to elements in the ordered set.   The block takes three arguments:           obj              The element in the ordered set.                idx              The index of the element in the ordered set.                stop              A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this value to true within the block.        The block returns a Boolean value that indicates whether obj passed the test.</param>
        /// <returns>The index of the corresponding value in the ordered set passes the test specified by predicate. If no objects in the ordered set pass the test, returns NSNotFound.</returns>
        [iOSVersion(5)]
        [Export("indexOfObjectAtIndexes")]
        public int IndexOfObjectAtIndexes(NSIndexSet indexSet, NSEnumerationOptions options, Func<AnyObject, int, CMutablePointer<ObjCBool>, bool> passingTest) { return 0; }
        
        /// <summary>
        /// Returns the index of the object in the ordered set that passes a test in a given block.
        /// </summary>
        /// <param name="predicate">The block to apply to elements in the ordered set.   The block takes three arguments:           obj              The element in the ordered set.                Term              The index of the element in the ordered set.                stop              A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this value to true within the block.</param>
        /// <returns>The index of the corresponding value in the ordered set that passes the test specified by predicate. If no objects in the ordered set pass the test, returns NSNotFound.</returns>
        [iOSVersion(5)]
        [Export("indexOfObjectPassingTest")]
        public int IndexOfObjectPassingTest(Func<AnyObject, int, CMutablePointer<ObjCBool>, bool> predicate) { return 0; }
        
        /// <summary>
        /// Returns the index of an object in the ordered set that passes a test in a given block for a given set of enumeration options.
        /// </summary>
        /// <param name="opts">A bitmask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>
        /// <param name="passingTest">The block to apply to elements in the ordered set.   The block takes three arguments:           obj              The element in the array.                idx              The index of the element in the ordered set.                stop              A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this value to true within the block.        The block returns a Boolean value that indicates whether obj passed the test.</param>
        /// <returns>The index whose corresponding value in the ordered set passes the test specified by predicate and opts. If no objects in the ordered set pass the test, returns NSNotFound.</returns>
        [iOSVersion(5)]
        [Export("indexOfObjectWithOptions")]
        public int IndexOfObjectWithOptions(NSEnumerationOptions opts, Func<AnyObject, int, CMutablePointer<ObjCBool>, bool> passingTest) { return 0; }
        
        /// <summary>
        /// Returns the index, from a given set of indexes, of the object in the ordered set that passes a test in a given block for a given set of enumeration options.
        /// </summary>
        /// <param name="indexSet">The indexes of the objects over which to enumerate.</param>
        /// <param name="options">A bitmask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>
        /// <param name="passingTest">The block to apply to elements in the ordered set.   The block takes three arguments:           obj              The element in the ordered set.                idx              The index of the element in the ordered set.                stop              A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this value to true within the block.        The block returns a Boolean value that indicates whether obj passed the test.</param>
        /// <returns>The index of the corresponding value in the ordered set that passes the test specified by predicate. If no objects in the ordered set pass the test, returns NSNotFound.</returns>
        [iOSVersion(5)]
        [Export("indexesOfObjectsAtIndexes")]
        public NSIndexSet IndexesOfObjectsAtIndexes(NSIndexSet indexSet, NSEnumerationOptions options, Func<AnyObject, int, CMutablePointer<ObjCBool>, bool> passingTest) { return null; }
        
        /// <summary>
        /// Returns the index of the object in the ordered set that passes a test in a given block.
        /// </summary>
        /// <param name="predicate">The block to apply to elements in the ordered set.   The block takes three arguments:           obj              The element in the ordered set.                Term              The index of the element in the ordered set.                stop              A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this value to true within the block.</param>
        /// <returns>The index of the corresponding value in the ordered set that passes the test specified by predicate. If no objects in the ordered set pass the test, returns NSNotFound..</returns>
        [iOSVersion(5)]
        [Export("indexesOfObjectsPassingTest")]
        public NSIndexSet IndexesOfObjectsPassingTest(Func<AnyObject, int, CMutablePointer<ObjCBool>, bool> predicate) { return null; }
        
        /// <summary>
        /// Returns the index of an object in the ordered set that passes a test in a given block for a given set of enumeration options.
        /// </summary>
        /// <param name="opts">A bitmask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>
        /// <param name="passingTest">The block to apply to elements in the ordered set.   The block takes three arguments:           obj              The element in the ordered set.                Term              The index of the element in the ordered set.                stop              A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this value to true within the block.</param>
        /// <returns>The index whose corresponding value in the ordered set passes the test specified by predicate and opts. If the opts bitmask specifies reverse order, then the last item that matches is returned. Otherwise, the index of the first matching object is returned. If no objects in the ordered set pass the test, returns NSNotFound.</returns>
        [iOSVersion(5)]
        [Export("indexesOfObjectsWithOptions")]
        public NSIndexSet IndexesOfObjectsWithOptions(NSEnumerationOptions opts, Func<AnyObject, int, CMutablePointer<ObjCBool>, bool> passingTest) { return null; }
        
        /// <summary>
        /// Returns an enumerator object that lets you access each object in the ordered set.
        /// </summary>
        /// <returns>An enumerator object that lets you access each object in the ordered set, in order, from the element at the lowest index upwards.</returns>
        [iOSVersion(5)]
        [Export("objectEnumerator")]
        public NSEnumerator ObjectEnumerator() { return null; }
        
        /// <summary>
        /// Returns an enumerator object that lets you access each object in the ordered set.
        /// </summary>
        /// <returns>An enumerator object that lets you access each object in the ordered set, in order, from the element at the highest index downwards.</returns>
        [iOSVersion(5)]
        [Export("reverseObjectEnumerator")]
        public NSEnumerator ReverseObjectEnumerator() { return null; }
        
        /// <summary>
        /// Returns an ordered set in the reverse order.
        /// </summary>
        /// <returns>Returns an ordered set in the reversed order of the receiver.</returns>
        [iOSVersion(5)]
        [Export("reversedOrderedSet")]
        public NSOrderedSet ReversedOrderedSet { get; private set; }
        
        /// <summary>
        /// Copies the objects contained in the ordered set that fall within the specified range to objects.
        /// </summary>
        /// <param name="objects">A C array of objects of size at least the length of the range specified by aRange.</param>
        /// <param name="range">A range within the bounds of the array.   If the location plus the length of the range is greater than the count of the array, this method raises an NSRangeException.</param>
        [iOSVersion(5)]
        [Export("getObjects")]
        public void GetObjects(AutoreleasingUnsafePointer<AnyObject> objects, NSRange range) { }
        
        /// <summary>
        /// Invokes setValue:forKey: on each of the receiver's members using the specified value and key
        /// </summary>
        /// <param name="value">The object value.</param>
        /// <param name="forKey">The key to store the value.</param>
        [iOSVersion(5)]
        [Export("setValue")]
        public void SetValue(AnyObject value, string forKey) { }
        
        /// <summary>
        /// Returns an ordered set containing the results of invoking valueForKey: using key on each of the ordered set’s objects.
        /// </summary>
        /// <param name="key">The key to retrieve.</param>
        /// <returns>The ordered set of the values for the retrieved key. The returned ordered set might not have the same number of members as the receiver.</returns>
        [iOSVersion(5)]
        [Export("valueForKey")]
        public AnyObject ValueForKey(string key) { return null; }
        
        /// <summary>
        /// Raises an exception.
        /// </summary>
        /// <param name="observer">The object to register for KVO notifications.</param>
        /// <param name="forKeyPath">The key path, relative to the array, of the property to observe. This value must not be nil.</param>
        /// <param name="options">A combination of NSKeyValueObservingOptions values that specifies what is included in observation notifications.</param>
        /// <param name="context">Arbitrary data that is passed to observer in observeValueForKeyPath:ofObject:change:context:.</param>
        [iOSVersion(5)]
        [Export("addObserver")]
        public void AddObserver(NSObject observer, string forKeyPath, NSKeyValueObservingOptions options, CMutableVoidPointer context) { }
        
        /// <summary>
        /// Raises an exception.
        /// </summary>
        /// <param name="observer">The object to remove as an observer.</param>
        /// <param name="forKeyPath">A key-path, relative to the set, for which observer is registered to receive KVO change notifications. This value must not be nil.</param>
        [iOSVersion(5)]
        [Export("removeObserver")]
        public void RemoveObserver(NSObject observer, string forKeyPath) { }
        
        /// <summary>
        /// Raises an exception.
        /// </summary>
        /// <param name="observer">The object to remove as an observer.</param>
        /// <param name="forKeyPath">A key-path, relative to the set, for which observer is registered to receive KVO change notifications. This value must not be nil.</param>
        /// <param name="context">The context passed to the notifications.</param>
        [iOSVersion(5)]
        [Export("removeObserver")]
        public void RemoveObserver(NSObject observer, string forKeyPath, CMutableVoidPointer context) { }
        
        /// <summary>
        /// Compares the receiving ordered set to another ordered set.
        /// </summary>
        /// <param name="other">The ordered set with which to compare the receiving ordered set.</param>
        /// <returns>true if the contents of other are equal to the contents of the receiving ordered set, otherwise false.</returns>
        [iOSVersion(5)]
        [Export("isEqualToOrderedSet")]
        public bool IsEqualToOrderedSet(NSOrderedSet other) { return false; }
        
        /// <summary>
        /// Returns a Boolean value that indicates whether at least one object in the receiving ordered set is also present in another given ordered set.
        /// </summary>
        /// <param name="other">The other ordered set.</param>
        /// <returns>true if at least one object in the receiving ordered set is also present in other, otherwise false.</returns>
        [iOSVersion(5)]
        [Export("intersectsOrderedSet")]
        public bool intersectsOrderedSet(NSOrderedSet other) { return false; }
        
        /// <summary>
        /// Returns a Boolean value that indicates whether at least one object in the receiving ordered set is also present in another given set.
        /// </summary>
        /// <param name="set">The set.</param>
        /// <returns>true if at least one object in the receiving ordered set is also present in other, otherwise false.</returns>
        [iOSVersion(5)]
        [Export("intersectsSet")]
        public bool intersectsSet(NSSet set) { return false; }
        
        /// <summary>
        /// Returns a Boolean value that indicates whether every object in the receiving ordered set is also present in another given ordered set.
        /// </summary>
        /// <param name="other">The ordered set with which to compare the receiving ordered set.</param>
        /// <returns>true if every object in the receiving set is also present in other, otherwise false.</returns>
        [iOSVersion(5)]
        [Export("isSubsetOfOrderedSet")]
        public bool IsSubsetOfOrderedSet(NSOrderedSet other) { return false; }
        
        /// <summary>
        /// Returns a Boolean value that indicates whether every object in the receiving ordered set is also present in another given set.
        /// </summary>
        /// <param name="set">The set with which to compare the receiving ordered set.</param>
        /// <returns>true if every object in the receiving ordered set is also present in set, otherwise false.</returns>
        [iOSVersion(5)]
        [Export("isSubsetOfSet")]
        public bool IsSubsetOfSet(NSSet set) { return false; }
        
        /// <summary>
        /// Returns an array of the ordered set’s elements sorted as specified by a given array of sort descriptors.
        /// </summary>
        /// <param name="sortDescriptors">An array of NSSortDescriptor objects.</param>
        /// <returns>An NSArray containing the ordered set’s elements sorted as specified by sortDescriptors.</returns>
        [iOSVersion(5)]
        [Export("sortedArrayUsingDescriptors")]
        public AnyObject[] SortedArrayUsingDescriptors(AnyObject[] sortDescriptors) { return null; }
        
        /// <summary>
        /// Returns an array that lists the receiving ordered set’s elements in ascending order, as determined by the comparison method specified by a given NSComparator block
        /// </summary>
        /// <param name="cmptr">A comparator block.</param>
        /// <returns>An array that lists the receiving ordered set’s elements in ascending order, as determined by the comparison method specified cmptr.</returns>
        [iOSVersion(5)]
        [Export("sortedArrayUsingComparator")]
        public AnyObject[] SortedArrayUsingComparator(NSComparator cmptr) { return null; }
        
        /// <summary>
        /// Returns an array that lists the receiving ordered set’s elements in ascending order, as determined by the comparison method specified by a given NSComparator block.
        /// </summary>
        /// <param name="opts">A bitmask that specifies the options for the sort (whether it should be performed concurrently and whether it should be performed stably).</param>
        /// <param name="usingComparator">A comparator block.</param>
        /// <returns>An array that lists the receiving ordered set’s elements in ascending order, as determined by the comparison method specified cmptr.</returns>
        [iOSVersion(5)]
        [Export("sortedArrayWithOptions")]
        public AnyObject[] SortedArrayWithOptions(NSSortOptions opts, NSComparator usingComparator) { return null; }
        
        /// <summary>
        /// Evaluates a given predicate against each object in the receiving ordered set and returns a new ordered set containing the objects for which the predicate returns true.
        /// </summary>
        /// <param name="predicate">The predicate against which to evaluate the receiving ordered set’s elements.</param>
        /// <returns>A new ordered set containing the objects in the receiving ordered set for which predicate returns true.</returns>
        [iOSVersion(5)]
        [Export("filteredOrderedSetUsingPredicate")]
        public NSOrderedSet FilteredOrderedSetUsingPredicate(NSPredicate predicate) { return null; }
        
        /// <summary>
        /// Returns a string that represents the contents of the ordered set, formatted as a property list.
        /// </summary>
        /// <returns>A string that represents the contents of the ordered set, formatted as a property list.</returns>
        [iOSVersion(5)]
        [Export("description")]
        public string Description { get; private set; }
        
        /// <summary>
        /// Returns a string that represents the contents of the ordered set, formatted as a property list.
        /// </summary>
        /// <param name="locale">An NSLocale object or an NSDictionary object that specifies options used for formatting each of the ordered set’s elements (where recognized). Specify nil if you don’t want the elements formatted.</param>
        /// <returns>A string that represents the contents of the ordered set, formatted as a property list.</returns>
        [iOSVersion(5)]
        [Export("descriptionWithLocale")]
        public string DescriptionWithLocale(AnyObject locale) { return ""; }
        
        /// <summary>
        /// Returns a string that represents the contents of the ordered set, formatted as a property list.
        /// </summary>
        /// <param name="locale">An NSLocale object or an NSDictionary object that specifies options used for formatting each of the array’s elements (where recognized). Specify nil if you don’t want the elements formatted.</param>
        /// <param name="indent">Specifies a level of indentation, to make the output more readable: the indentation is (4 spaces) * level.</param>
        /// <returns>A string that represents the contents of the ordered set, formatted as a property list.</returns>
        [iOSVersion(5)]
        [Export("descriptionWithLocale")]
        public string DescriptionWithLocale(AnyObject locale, int indent) { return ""; }
        
        /// <summary>
        /// Returns a representation of the ordered set as an array.
        /// </summary>
        /// <returns>An array containing the ordered set’s elements.</returns>
        [iOSVersion(5)]
        [Export("array")]
        public AnyObject[] Array { get; private set; }
        
        /// <summary>
        /// Returns a representation of the set containing the contents of the ordered set.
        /// </summary>
        /// <returns>A set containing the ordered set’s elements.</returns>
        [iOSVersion(5)]
        [Export("set")]
        public NSSet Set { get; private set; }
    }
}