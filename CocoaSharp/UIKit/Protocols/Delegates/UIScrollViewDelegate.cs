using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The methods declared by the UIScrollViewDelegate protocol allow the adopting delegate to respond to messages from the UIScrollView class and thus respond to, and in some affect, operations such as scrolling, zooming, deceleration of scrolled content, and scrolling animations.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIScrollViewDelegate_Protocol/index.html#//apple_ref/occ/intf/UIScrollViewDelegate"/>    [iOSVersion(2)]    public interface UIScrollViewDelegate//: NSObjectProtocol    {        /// <summary>        /// Tells the delegate when the user scrolls the content view within the receiver.        /// </summary>        /// <param name="scrollView">The scroll-view object in which the scrolling occurred.</param>        //[iOSVersion(2)]        //[Export("scrollViewDidScroll")]        //[Optional]        void ScrollViewDidScroll(UIScrollView scrollView);                /// <summary>        /// Tells the delegate when the scroll view is about to start scrolling the content.        /// </summary>        /// <param name="scrollView">The scroll-view object that is about to scroll the content view.</param>        //[iOSVersion(2)]        //[Export("scrollViewWillBeginDragging")]        //[Optional]        void ScrollViewWillBeginDragging(UIScrollView scrollView);                /// <summary>        /// Tells the delegate when the user finishes scrolling the content.        /// </summary>        /// <param name="scrollView">The scroll-view object where the user ended the touch..</param>        /// <param name="withVelocity">The velocity of the scroll view (in points) at the moment the touch was released.</param>        /// <param name="targetContentOffset">The expected offset when the scrolling action decelerates to a stop.</param>        //[iOSVersion(5)]        //[Export("scrollViewWillEndDragging")]        //[Optional]        void ScrollViewWillEndDragging(UIScrollView scrollView, CGPoint withVelocity, UnsafeMutablePointer<CGPoint> targetContentOffset);                /// <summary>        /// Tells the delegate when dragging ended in the scroll view.        /// </summary>        /// <param name="scrollView">The scroll-view object that finished scrolling the content view.</param>        /// <param name="willDecelerate">true if the scrolling movement will continue, but decelerate, after a touch-up gesture during a dragging operation. If the value is false, scrolling stops immediately upon touch-up.</param>        //[iOSVersion(2)]        //[Export("scrollViewDidEndDragging")]        //[Optional]        void ScrollViewDidEndDragging(UIScrollView scrollView, bool willDecelerate);                /// <summary>        /// Asks the delegate if the scroll view should scroll to the top of the content.        /// </summary>        /// <param name="scrollView">The scroll-view object requesting this information.</param>        //[iOSVersion(2)]        //[Export("scrollViewShouldScrollToTop")]        //[Optional]        bool ScrollViewShouldScrollToTop(UIScrollView scrollView);                /// <summary>        /// Tells the delegate that the scroll view scrolled to the top of the content.        /// </summary>        /// <param name="scrollView">The scroll-view object that perform the scrolling operation.</param>        //[iOSVersion(2)]        //[Export("scrollViewDidScrollToTop")]        //[Optional]        void ScrollViewDidScrollToTop(UIScrollView scrollView);                /// <summary>        /// Tells the delegate that the scroll view is starting to decelerate the scrolling movement.        /// </summary>        /// <param name="scrollView">The scroll-view object that is decelerating the scrolling of the content view.</param>        //[iOSVersion(2)]        //[Export("scrollViewWillBeginDecelerating")]        //[Optional]        void ScrollViewWillBeginDecelerating(UIScrollView scrollView);                /// <summary>        /// Tells the delegate that the scroll view has ended decelerating the scrolling movement.        /// </summary>        /// <param name="scrollView">The scroll-view object that is decelerating the scrolling of the content view.</param>        //[iOSVersion(2)]        //[Export("scrollViewDidEndDecelerating")]        //[Optional]        void ScrollViewDidEndDecelerating(UIScrollView scrollView);                /// <summary>        /// Asks the delegate for the view to scale when zooming is about to occur in the scroll view.        /// </summary>        /// <param name="scrollView">The scroll-view object displaying the content view.</param>        //[iOSVersion(2)]        //[Export("viewForZoomingInScrollView")]        //[Optional]        UIView ViewForZoomingInScrollView(UIScrollView scrollView);                /// <summary>        /// Tells the delegate that zooming of the content in the scroll view is about to commence.        /// </summary>        /// <param name="scrollView">The scroll-view object displaying the content view.</param>        /// <param name="withView">The view object whose content is about to be zoomed.</param>        //[iOSVersion(3.2)]        //[Export("scrollViewWillBeginZooming")]        //[Optional]        void ScrollViewWillBeginZooming(UIScrollView scrollView, UIView withView);                /// <summary>        /// Tells the delegate when zooming of the content in the scroll view completed.        /// </summary>        /// <param name="scrollView">The scroll-view object displaying the content view.</param>        /// <param name="withView">The view object representing that part of the content view that needs to be scaled.</param>        /// <param name="atScale">The scale factor to use for scaling; this value must be between the limits established by the UIScrollView properties maximumZoomScale and minimumZoomScale.</param>        //[iOSVersion(2)]        //[Export("scrollViewDidEndZooming")]        //[Optional]        void ScrollViewDidEndZooming(UIScrollView scrollView, UIView withView, CGFloat atScale);                /// <summary>        /// Tells the delegate that the scroll view’s zoom factor changed.        /// </summary>        /// <param name="scrollView">The scroll-view object whose zoom factor changed.</param>        //[iOSVersion(3.2)]        //[Export("scrollViewDidZoom")]        //[Optional]        void ScrollViewDidZoom(UIScrollView scrollView);                /// <summary>        /// Tells the delegate when a scrolling animation in the scroll view concludes.        /// </summary>        /// <param name="scrollView">The scroll-view object that is performing the scrolling animation.</param>        //[iOSVersion(2)]        //[Export("scrollViewDidEndScrollingAnimation")]        //[Optional]        void ScrollViewDidEndScrollingAnimation(UIScrollView scrollView);    }}