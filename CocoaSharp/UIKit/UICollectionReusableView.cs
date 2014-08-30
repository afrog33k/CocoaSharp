using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UICollectionReusableView class defines the behavior for all cells and supplementary views presented by a collection view. Reusable views are so named because the collection view places them on a reuse queue rather than deleting them when they are scrolled out of the visible bounds. Such a view can then be retrieved and repurposed for a different set of content.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UICollectionReusableView_class/index.html#//apple_ref/occ/cl/UICollectionReusableView"/>    [iOSVersion(6)]    public class UICollectionReusableView : UIView//, AnyObject, NSCoding, NSObjectProtocol, Reflectable, UIAccessibilityIdentification, UIAppearance, UIAppearanceContainer, UICoordinateSpace, UIDynamicItem, UITraitEnvironment    {        public UICollectionReusableView() { }        /// <summary>        /// Performs any clean up necessary to prepare the view for use again.        /// </summary>        [iOSVersion(6)]        [Export("prepareForReuse")]        public virtual void PrepareForReuse() {  }                /// <summary>        /// Gives the cell a chance to modify the attributes provided by the layout object.        /// </summary>        /// <param name="layoutAttributes">The attributes provided by the layout object. These attributes represent the values that the layout intends to apply to the cell.</param>        [iOSVersion(8)]        [Export("preferredLayoutAttributesFittingAttributes")]        public virtual UICollectionViewLayoutAttributes PreferredLayoutAttributesFittingAttributes(UICollectionViewLayoutAttributes layoutAttributes) { return default(UICollectionViewLayoutAttributes); }                /// <summary>        /// Applies the specified layout attributes to the view.        /// </summary>        /// <param name="layoutAttributes">The layout attributes to apply.</param>        [iOSVersion(6)]        [Export("applyLayoutAttributes")]        public virtual void ApplyLayoutAttributes(UICollectionViewLayoutAttributes layoutAttributes) {  }                /// <summary>        /// Tells your view that the layout object of the collection view is about to change.        /// </summary>        /// <param name="oldLayout">The current layout object associated with the collection view.</param>        /// <param name="toLayout">The new layout object that is about to be applied to the collection view.</param>        [iOSVersion(6)]        [Export("willTransitionFromLayout")]        public virtual void WillTransitionFromLayout(UICollectionViewLayout oldLayout, UICollectionViewLayout toLayout) {  }                /// <summary>        /// Tells your view that the layout object of the collection view changed.        /// </summary>        /// <param name="oldLayout">The collection view’s previous layout object.</param>        /// <param name="toLayout">The current layout object associated with the collection view.</param>        [iOSVersion(6)]        [Export("didTransitionFromLayout")]        public virtual void DidTransitionFromLayout(UICollectionViewLayout oldLayout, UICollectionViewLayout toLayout) {  }                /// <summary>        /// A string that identifies the purpose of the view. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("reuseIdentifier")]        public string ReuseIdentifier { get; private set; }    }}