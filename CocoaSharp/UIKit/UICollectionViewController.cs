using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace UIKit{    /// <summary>    /// The UICollectionViewController class represents a view controller whose content consists of a collection view. It implements the following behavior:    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UICollectionViewController_clas/index.html#//apple_ref/occ/cl/UICollectionViewController"/>    [iOSVersion(6)]    public class UICollectionViewController : UIViewController//, AnyObject, NSCoding, NSExtensionRequestHandling, NSObjectProtocol, UIAppearanceContainer, UICollectionViewDataSource, UICollectionViewDelegate, UIContentContainer, UIScrollViewDelegate, UIStateRestoring, UITraitEnvironment    {        /// <summary>        /// Initializes a collection view controller and configures the collection view with the provided layout.        /// </summary>        /// <param name="collectionViewLayout">The layout object to associate with the collection view. The layout controls how the collection view presents its cells and supplementary views.</param>        [iOSVersion(6)]        public UICollectionViewController(UICollectionViewLayout collectionViewLayout) { }                /// <summary>        /// The collection view object managed by this view controller.        /// </summary>        [iOSVersion(6)]        [Export("collectionView")]        public UICollectionView CollectionView { get; set; }                /// <summary>        /// The layout object used to initialize the collection view controller. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("collectionViewLayout")]        public UICollectionViewLayout CollectionViewLayout { get; private set; }                /// <summary>        /// A Boolean value indicating if the controller clears the selection when the collection view appears.        /// </summary>        [iOSVersion(6)]        [Export("clearsSelectionOnViewWillAppear")]        public bool ClearsSelectionOnViewWillAppear { get; set; }                /// <summary>        /// A Boolean that indicates whether the collection view controller coordinates with a navigation controller for transitions.        /// </summary>        [iOSVersion(7)]        [Export("useLayoutToLayoutNavigationTransitions")]        public bool UseLayoutToLayoutNavigationTransitions { get; set; }    }}