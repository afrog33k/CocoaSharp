using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// An object that adopts the UICollectionViewDataSource protocol is responsible for providing the data and views required by a collection view. A data source object represents your app’s data model and vends information to the collection view as needed. It also handles the creation and configuration of cells and supplementary views used by the collection view to display your data.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UICollectionViewDataSource_protocol/index.html#//apple_ref/occ/intf/UICollectionViewDataSource"/>    [iOSVersion(6)]    [Export("")]    public interface UICollectionViewDataSource//: NSObjectProtocol    {        /// <summary>        /// Asks the data source for the number of items in the specified section. (required)        /// </summary>        /// <param name="collectionView">An object representing the collection view requesting this information.</param>        /// <param name="numberOfItemsInSection">An index number identifying a section in collectionView. This index value is 0-based.</param>        [iOSVersion(6)]        [Export("collectionView")]        int CollectionView(UICollectionView collectionView, int numberOfItemsInSection);                /// <summary>        /// Asks the data source for the number of sections in the collection view.        /// </summary>        /// <param name="collectionView">An object representing the collection view requesting this information.</param>        //[iOSVersion(6)]        //[Export("numberOfSectionsInCollectionView")]        //[InheritOptional]        //int NumberOfSectionsInCollectionView(UICollectionView collectionView);                /// <summary>        /// Asks the data source for the cell that corresponds to the specified item in the collection view. (required)        /// </summary>        /// <param name="collectionView">An object representing the collection view requesting this information.</param>        /// <param name="cellForItemAtIndexPath">The index path that specifies the location of the item.</param>        [iOSVersion(6)]        [Export("collectionView")]        UICollectionViewCell CollectionView(UICollectionView collectionView, NSIndexPath cellForItemAtIndexPath);                /// <summary>        /// Asks the collection view to provide a supplementary view to display in the collection view.        /// </summary>        /// <param name="collectionView">An object representing the collection view requesting this information.</param>        /// <param name="viewForSupplementaryElementOfKind">The kind of supplementary view to provide. The value of this string is defined by the layout object that supports the supplementary view.</param>        /// <param name="atIndexPath">The index path that specifies the location of the new supplementary view.</param>        //[iOSVersion(6)]        //[Export("collectionView")]        //[InheritOptional]        //UICollectionReusableView CollectionView(UICollectionView collectionView, string viewForSupplementaryElementOfKind, NSIndexPath atIndexPath);    }}