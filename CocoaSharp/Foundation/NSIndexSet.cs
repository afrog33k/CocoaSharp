using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// The NSIndexSet class represents an immutable collection of unique unsigned integers, known as indexes because of the way they are used. This collection is referred to as an index set. Indexes must be in the range 0 .. NSNotFound - 1.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSIndexSet_Class/index.html#//apple_ref/occ/cl/NSIndexSet"/>    [iOSVersion(2)]    public class NSIndexSet : NSObject//, AnyObject, NSCoding, NSCopying, NSMutableCopying, NSObjectProtocol, NSSecureCoding    {        /// <summary>        /// Initializes an allocated NSIndexSet object with an index.        /// </summary>        /// <param name="index">An index. Must be in the range 0 .. NSNotFound - 1.</param>        [iOSVersion(2)]        [Export("convenience init")]        public NSIndexSet(int index) { }                /// <summary>        /// Initializes an allocated NSIndexSet object with an index range.        /// </summary>        /// <param name="indexesInRange">An index range. Must be in the range 0 .. NSNotFound - 1..</param>        [iOSVersion(2)]        public NSIndexSet(NSRange indexesInRange) { }                /// <summary>        /// Initializes an allocated NSIndexSet object with an index set.        /// </summary>        /// <param name="indexSet">An index set.</param>        [iOSVersion(2)]        public NSIndexSet(NSIndexSet indexSet) { }                /// <summary>        /// Indicates whether the index set contains a specific index.        /// </summary>        /// <param name="index">Index being inquired about.</param>        [iOSVersion(2)]        [Export("containsIndex")]        public bool ContainsIndex(int index) { return default(bool); }                /// <summary>        /// Indicates whether the receiving index set contains a superset of the indexes in another index set.        /// </summary>        /// <param name="indexSet">Index set being inquired about.</param>        [iOSVersion(2)]        [Export("containsIndexes")]        public bool ContainsIndexes(NSIndexSet indexSet) { return default(bool); }                /// <summary>        /// Indicates whether the index set contains the indexes represented by an index range.        /// </summary>        /// <param name="indexRange">The index range being inquired about.</param>        [iOSVersion(2)]        [Export("containsIndexesInRange")]        public bool ContainsIndexesInRange(NSRange indexRange) { return default(bool); }                /// <summary>        /// Indicates whether the index set contains any of the indexes in a range.        /// </summary>        /// <param name="indexRange">Index range being inquired about.</param>        [iOSVersion(2)]        [Export("intersectsIndexesInRange")]        public bool IntersectsIndexesInRange(NSRange indexRange) { return default(bool); }                /// <summary>        /// Returns the number of indexes in the index set that are members of a given range.        /// </summary>        /// <param name="indexRange">Index range being inquired about.</param>        [iOSVersion(2)]        [Export("countOfIndexesInRange")]        public int CountOfIndexesInRange(NSRange indexRange) { return default(int); }                /// <summary>        /// Returns the index of the first object that passes the predicate Block test.        /// </summary>        /// <param name="predicate">The Block to apply to elements in the set.        ///   The Block takes two arguments:        ///       idx        ///   The index of the object.        ///       stop        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this Boolean to YES within the Block.        ///   The Block returns a Boolean value that indicates whether obj passed the test.</param>        [iOSVersion(4)]        [Export("indexPassingTest")]        public int IndexPassingTest(Func<int, UnsafePointer<ObjCBool>, bool> predicate) { return default(int); }                /// <summary>        /// Returns an NSIndexSet containing the receiving index set’s objects that pass the Block test.        /// </summary>        /// <param name="predicate">The Block to apply to elements in the set.        ///   The Block takes two arguments:        ///       idx        ///   The index of the object.        ///       stop        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this Boolean to YES within the Block.        ///   The Block returns a Boolean value that indicates whether obj passed the test.</param>        [iOSVersion(4)]        [Export("indexesPassingTest")]        public NSIndexSet IndexesPassingTest(Func<int, UnsafePointer<ObjCBool>, bool> predicate) { return default(NSIndexSet); }                /// <summary>        /// Returns the index of the first object that passes the predicate Block test using the specified enumeration options.        /// </summary>        /// <param name="opts">A bitmask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order). See NSEnumerationOptions for the supported values.</param>        /// <param name="passingTest">The Block to apply to elements in the set.        ///   The Block takes two arguments:        ///       idx        ///   The index of the object.        ///       stop        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this Boolean to YES within the Block.        ///   The Block returns a Boolean value that indicates whether obj passed the test.</param>        [iOSVersion(4)]        [Export("indexWithOptions")]        public int IndexWithOptions(NSEnumerationOptions opts, Func<int, UnsafePointer<ObjCBool>, bool> passingTest) { return default(int); }                /// <summary>        /// Returns an NSIndexSet containing the receiving index set’s objects that pass the Block test using the specified enumeration options.        /// </summary>        /// <param name="opts">A bitmask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order). See NSEnumerationOptions for the supported values.</param>        /// <param name="passingTest">The Block to apply to elements in the set.        ///   The Block takes two arguments:        ///       idx        ///   The index of the object.        ///       stop        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this Boolean to YES within the Block.        ///   The Block returns a Boolean value that indicates whether obj passed the test.</param>        [iOSVersion(4)]        [Export("indexesWithOptions")]        public NSIndexSet IndexesWithOptions(NSEnumerationOptions opts, Func<int, UnsafePointer<ObjCBool>, bool> passingTest) { return default(NSIndexSet); }                /// <summary>        /// Returns the index of the first object in the specified range that passes the predicate Block test.        /// </summary>        /// <param name="range">The range of indexes to test.</param>        /// <param name="options">A bitmask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order). See NSEnumerationOptions for the supported values.</param>        /// <param name="passingTest">The Block to apply to elements in the set.        ///   The Block takes two arguments:        ///       idx        ///   The index of the object.        ///       stop        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this Boolean to YES within the Block.        ///   The Block returns a Boolean value that indicates whether obj passed the test.</param>        [iOSVersion(4)]        [Export("indexInRange")]        public int IndexInRange(NSRange range, NSEnumerationOptions options, Func<int, UnsafePointer<ObjCBool>, bool> passingTest) { return default(int); }                /// <summary>        /// Returns an NSIndexSet containing the receiving index set’s objects in the specified range that pass the Block test.        /// </summary>        /// <param name="range">The range of indexes to test.</param>        /// <param name="options">A bitmask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order). See NSEnumerationOptions for the supported values.</param>        /// <param name="passingTest">The Block to apply to elements in the set.        ///   The Block takes two arguments:        ///       idx        ///   The index of the object.        ///       stop        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this Boolean to YES within the Block.        ///   The Block returns a Boolean value that indicates whether obj passed the test.</param>        [iOSVersion(4)]        [Export("indexesInRange")]        public NSIndexSet IndexesInRange(NSRange range, NSEnumerationOptions options, Func<int, UnsafePointer<ObjCBool>, bool> passingTest) { return default(NSIndexSet); }                /// <summary>        /// Enumerates over the ranges in the range of objects using the block        /// </summary>        /// <param name="range">The range of items to enumerate. If the range intersects a range of the receiver's indexes, then that intersection will be passed to the block.</param>        /// <param name="options">A bitmask that specifies the NSEnumerationOptions for the enumeration.</param>        /// <param name="usingBlock">The block to apply to elements in the index set.        ///   The block takes two arguments:        ///       range        ///   The range of elements.        ///       stop        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.</param>        [iOSVersion(5)]        [Export("enumerateRangesInRange")]        public void EnumerateRangesInRange(NSRange range, NSEnumerationOptions options, Action<NSRange, UnsafePointer<ObjCBool>> usingBlock) {  }                /// <summary>        /// Executes a given block using each object in the index set, in the specified ranges.        /// </summary>        /// <param name="block">The block to apply to elements in the index set.        ///   The block takes two arguments:        ///       range        ///   The range of objects of the elements in the index set.        ///       stop        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.</param>        [iOSVersion(5)]        [Export("enumerateRangesUsingBlock")]        public void EnumerateRangesUsingBlock(Action<NSRange, UnsafePointer<ObjCBool>> block) {  }                /// <summary>        /// Executes a given block using each object in the index set, in the specified ranges.        /// </summary>        /// <param name="opts">A bitmask that specifies the NSEnumerationOptions for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>        /// <param name="usingBlock">The block to apply to elements in the index set.        ///   The block takes two arguments:        ///       range        ///   The range of objects of the elements in the index set.        ///       stop        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.</param>        [iOSVersion(5)]        [Export("enumerateRangesWithOptions")]        public void EnumerateRangesWithOptions(NSEnumerationOptions opts, Action<NSRange, UnsafePointer<ObjCBool>> usingBlock) {  }                /// <summary>        /// Indicates whether the indexes in the receiving index set are the same indexes contained in another index set.        /// </summary>        /// <param name="indexSet">Index set being inquired about.</param>        [iOSVersion(2)]        [Export("isEqualToIndexSet")]        public bool IsEqualToIndexSet(NSIndexSet indexSet) { return default(bool); }                /// <summary>        /// Returns either the closest index in the index set that is less than a specific index or the not-found indicator.        /// </summary>        /// <param name="index">Index being inquired about.</param>        [iOSVersion(2)]        [Export("indexLessThanIndex")]        public int IndexLessThanIndex(int index) { return default(int); }                /// <summary>        /// Returns either the closest index in the index set that is less than or equal to a specific index or the not-found indicator.        /// </summary>        /// <param name="index">Index being inquired about.</param>        [iOSVersion(2)]        [Export("indexLessThanOrEqualToIndex")]        public int IndexLessThanOrEqualToIndex(int index) { return default(int); }                /// <summary>        /// Returns either the closest index in the index set that is greater than or equal to a specific index or the not-found indicator.        /// </summary>        /// <param name="index">Index being inquired about.</param>        [iOSVersion(2)]        [Export("indexGreaterThanOrEqualToIndex")]        public int IndexGreaterThanOrEqualToIndex(int index) { return default(int); }                /// <summary>        /// Returns either the closest index in the index set that is greater than a specific index or the not-found indicator.        /// </summary>        /// <param name="index">Index being inquired about.</param>        [iOSVersion(2)]        [Export("indexGreaterThanIndex")]        public int IndexGreaterThanIndex(int index) { return default(int); }                /// <summary>        /// The index set fills an index buffer with the indexes contained both in the index set and in an index range, returning the number of indexes copied.        /// </summary>        /// <param name="indexBuffer">Index buffer to fill.</param>        /// <param name="maxCount">Maximum size of indexBuffer.</param>        /// <param name="inIndexRange">Index range to compare with indexes in the index set; nil represents all the indexes in the index set. Indexes in the index range and in the index set are copied to indexBuffer. On output, the range of indexes not copied to indexBuffer.</param>        [iOSVersion(2)]        [Export("getIndexes")]        public int GetIndexes(UnsafePointer<int> indexBuffer, int maxCount, NSRangePointer inIndexRange) { return default(int); }                /// <summary>        /// Executes a given Block using each object in the index set.        /// </summary>        /// <param name="block">The Block to apply to elements in the set.        ///   The Block takes two arguments:        ///       idx        ///   The index of the object.        ///       stop        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this Boolean to YES within the Block.</param>        [iOSVersion(4)]        [Export("enumerateIndexesUsingBlock")]        public void EnumerateIndexesUsingBlock(Action<int, UnsafePointer<ObjCBool>> block) {  }                /// <summary>        /// Executes a given Block over the index set’s indexes, using the specified enumeration options.        /// </summary>        /// <param name="opts">A bitmask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order). See NSEnumerationOptions for the supported values.</param>        /// <param name="usingBlock">The Block to apply to elements in the set.        ///   The Block takes two arguments:        ///       idx        ///   The index of the object.        ///       stop        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this Boolean to YES within the Block.</param>        [iOSVersion(4)]        [Export("enumerateIndexesWithOptions")]        public void EnumerateIndexesWithOptions(NSEnumerationOptions opts, Action<int, UnsafePointer<ObjCBool>> usingBlock) {  }                /// <summary>        /// Executes a given Block using the indexes in the specified range, using the specified enumeration options.        /// </summary>        /// <param name="range">The range to enumerate.</param>        /// <param name="options">A bitmask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order). See NSEnumerationOptions for the supported values.</param>        /// <param name="usingBlock">The Block to apply to elements in the set.        ///   The Block takes two arguments:        ///       idx        ///   The index of the object.        ///       stop        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this Boolean to YES within the Block.</param>        [iOSVersion(4)]        [Export("enumerateIndexesInRange")]        public void EnumerateIndexesInRange(NSRange range, NSEnumerationOptions options, Action<int, UnsafePointer<ObjCBool>> usingBlock) {  }                /// <summary>        /// The number of indexes in the index set. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("count")]        public int Count { get; private set; }                /// <summary>        /// The first index in the index set. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("firstIndex")]        public int FirstIndex { get; private set; }                /// <summary>        /// The last index in the index set. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("lastIndex")]        public int LastIndex { get; private set; }    }}