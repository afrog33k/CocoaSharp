using CoreGraphics;
using ObjectiveC;
        public CGPoint ConvertPoint(CGPoint point, UIView toView) { return new CGPoint(); }
        public CGPoint ConvertPoint(CGPoint point, UIView fromView) { return new CGPoint(); }
        public CGRect ConvertRect(CGRect rect, UIView toView) { return new CGRect(); }
        public CGRect ConvertRect(CGRect rect, UIView fromView) { return new CGRect(); }
    }

    /// <summary>
    /// Options for animating views using block objects.
    /// </summary>
    public enum UIViewAnimationOptions
    {
        /// <summary>
        /// Lay out subviews at commit time so that they are animated along with their parent.
        /// </summary>
        [iOSVersion(4)]
        LayoutSubviews,

        /// <summary>
        /// Allow the user to interact with views while they are being animated.
        /// </summary>
        [iOSVersion(4)]
        AllowUserinteraction,

        /// <summary>
        /// Start the animation from the current setting associated with an already in-flight animation. If this key is not present, any in-flight animations are allowed to finish before the new animation is started. If another animation is not in flight, this key has no effect.
        /// </summary>
        [iOSVersion(4)]
        BeginFromCurrentState,

        /// <summary>
        /// Repeat the animation indefinitely.
        /// </summary>
        [iOSVersion(4)]
        Repeat,

        /// <summary>
        /// Run the animation backwards and forwards. Must be combined with the UIViewAnimationOptionRepeat option.
        /// </summary>
        [iOSVersion(4)]
        Autoreverse,

        /// <summary>
        /// Force the animation to use the original duration value specified when the animation was submitted. If this key is not present, the animation inherits the remaining duration of the in-flight animation, if any.
        /// </summary>
        [iOSVersion(4)]
        OverrideInheritedDuration,

        /// <summary>
        /// Force the animation to use the original curve value specified when the animation was submitted. If this key is not present, the animation inherits the curve of the in-flight animation, if any.
        /// </summary>
        [iOSVersion(4)]
        OverrideInheritedCurve,

        /// <summary>
        /// Animate the views by changing the property values dynamically and redrawing the view. If this key is not present, the views are animated using a snapshot image.
        /// </summary>
        [iOSVersion(4)]
        AllowAnimatedContent,

        /// <summary>
        /// When present, this key causes views to be hidden or shown (instead of removed or added) when performing a view transition. Both views must already be present in the parent view’s hierarchy when using this key. If this key is not present, the to-view in a transition is added to, and the from-view is removed from, the parent view’s list of subviews.
        /// </summary>
        [iOSVersion(4)]
        ShowHideTransitionViews,

        /// <summary>
        /// The option to not inherit the animation type or any options.
        /// </summary>
        [iOSVersion(4)]
        OverrideInheritedOptions,

        /// <summary>
        /// An ease-in ease-out curve causes the animation to begin slowly, accelerate through the middle of its duration, and then slow again before completing.
        /// </summary>
        [iOSVersion(4)]
        CurveEaseInOut,

        /// <summary>
        /// An ease-in curve causes the animation to begin slowly, and then speed up as it progresses.
        /// </summary>
        [iOSVersion(4)]
        CurveEaseIn,

        /// <summary>
        /// An ease-out curve causes the animation to begin quickly, and then slow as it completes.
        /// </summary>
        [iOSVersion(4)]
        CurveEaseOut,

        /// <summary>
        /// A linear animation curve causes an animation to occur evenly over its duration.
        /// </summary>
        [iOSVersion(4)]
        CurveLinear,

        /// <summary>
        /// No transition is specified.
        /// </summary>
        [iOSVersion(4)]
        TransitionNone,

        /// <summary>
        /// A transition that flips a view around its vertical axis from left to right. The left side of the view moves toward the front and right side toward the back.
        /// </summary>
        [iOSVersion(4)]
        TransitionFlipFromLeft,

        /// <summary>
        /// A transition that flips a view around its vertical axis from right to left. The right side of the view moves toward the front and left side toward the back.
        /// </summary>
        [iOSVersion(4)]
        TransitionFlipFromRight,

        /// <summary>
        /// A transition that curls a view up from the bottom.
        /// </summary>
        [iOSVersion(4)]
        TransitionCurlUp,

        /// <summary>
        /// A transition that curls a view down from the top.
        /// </summary>
        [iOSVersion(4)]
        TransitionCurlDown,

        /// <summary>
        /// A transition that dissolves from one view to the next.
        /// </summary>
        [iOSVersion(4)]
        TransitionCrossDissolve,

        /// <summary>
        /// A transition that flips a view around its horizontal axis from top to bottom. The top side of the view moves toward the front and the bottom side toward the back.
        /// </summary>
        [iOSVersion(4)]
        TransitionFlipFromTop,

        /// <summary>
        /// A transition that flips a view around its horizontal axis from bottom to top. The bottom side of the view moves toward the front and the top side toward the back.
        /// </summary>
        [iOSVersion(4)]
        TransitionFlipFromBottom,
    }

    /// <summary>
    /// Specifies the supported animation curves.
    /// </summary>
    public enum UIViewAnimationCurve
    {
        /// <summary>
        /// An ease-in ease-out curve causes the animation to begin slowly, accelerate through the middle of its duration, and then slow again before completing. This is the default curve for most animations.
        /// </summary>
        [iOSVersion(2)]
        EaseInOut,

        /// <summary>
        /// An ease-in curve causes the animation to begin slowly, and then speed up as it progresses.
        /// </summary>
        [iOSVersion(2)]
        EaseIn,

        /// <summary>
        /// An ease-out curve causes the animation to begin quickly, and then slow down as it completes.
        /// </summary>
        [iOSVersion(2)]
        EaseOut,

        /// <summary>
        /// A linear animation curve causes an animation to occur evenly over its duration.
        /// </summary>
        [iOSVersion(2)]
        Linear,
    }
    /// <summary>
    /// Options to specify how a view adjusts its content when its size changes.
    /// </summary>
    public enum UIViewContentMode
    {
        /// <summary>
        /// The option to scale the content to fit the size of itself by changing the aspect ratio of the content if necessary.
        /// </summary>
        [iOSVersion(2)]
        ScaleToFill,

        /// <summary>
        /// The option to scale the content to fit the size of the view by maintaining the aspect ratio. Any remaining area of the view’s bounds is transparent.
        /// </summary>
        [iOSVersion(2)]
        ScaleAspectFit,

        /// <summary>
        /// The option to scale the content to fill the size of the view. Some portion of the content may be clipped to fill the view’s bounds.
        /// </summary>
        [iOSVersion(2)]
        ScaleAspectFill,

        /// <summary>
        /// The option to redisplay the view when the bounds change by invoking the setNeedsDisplay method.
        /// </summary>
        [iOSVersion(2)]
        Redraw,

        /// <summary>
        /// The option to center the content in the view’s bounds, keeping the proportions the same.
        /// </summary>
        [iOSVersion(2)]
        Center,

        /// <summary>
        /// The option to center the content aligned at the top in the view’s bounds.
        /// </summary>
        [iOSVersion(2)]
        Top,

        /// <summary>
        /// The option to center the content aligned at the bottom in the view’s bounds.
        /// </summary>
        [iOSVersion(2)]
        Bottom,

        /// <summary>
        /// The option to align the content on the left of the view.
        /// </summary>
        [iOSVersion(2)]
        Left,

        /// <summary>
        /// The option to align the content on the right of the view.
        /// </summary>
        [iOSVersion(2)]
        Right,

        /// <summary>
        /// The option to align the content in the top-left corner of the view.
        /// </summary>
        [iOSVersion(2)]
        TopLeft,

        /// <summary>
        /// The option to align the content in the top-right corner of the view.
        /// </summary>
        [iOSVersion(2)]
        TopRight,

        /// <summary>
        /// The option to align the content in the bottom-left corner of the view.
        /// </summary>
        [iOSVersion(2)]
        BottomLeft,

        /// <summary>
        /// The option to align the content in the bottom-right corner of the view.
        /// </summary>
        [iOSVersion(2)]
        BottomRight,
    }

    /// <summary>
    /// The tint adjustment mode for the view.
    /// </summary>
    public enum UIViewTintAdjustmentMode
    {
        /// <summary>
        /// The tint adjustment mode of the view is the same as its superview's tint adjustment mode (or UIViewTintAdjustmentModeNormal if the view has no superview).
        /// </summary>
        [iOSVersion(7)]
        Automatic,

        /// <summary>
        /// The view's tintColor property returns the completely unmodified tint color of the view.
        /// </summary>
        [iOSVersion(7)]
        Normal,

        /// <summary>
        /// The view's tintColor property returns a desaturated, dimmed version of the view's original tint color.
        /// </summary>
        [iOSVersion(7)]
        Dimmed,
    }

    /// <summary>
    /// Option to remove the views from the hierarchy when animation is complete.
    /// </summary>
    public enum UISystemAnimation
    {
        /// <summary>
        /// Option to remove views from the view hierarchy when animation is complete.
        /// </summary>
        [iOSVersion(7)]
        Delete,
    }
    /// <summary>
    /// Options for automatic view resizing.
    /// </summary>
    public enum UIViewAutoresizing
    {
        /// <summary>
        /// The option for indicating that the view does not resize.
        /// </summary>
        [iOSVersion(2)]
        None,

        /// <summary>
        /// Resizing performed by expanding or shrinking a view in the direction of the left margin.
        /// </summary>
        [iOSVersion(2)]
        FlexibleLeftMargin,

        /// <summary>
        /// Resizing performed by expanding or shrinking a view’s width.
        /// </summary>
        [iOSVersion(2)]
        FlexibleWidth,

        /// <summary>
        /// Resizing performed by expanding or shrinking a view in the direction of the right margin.
        /// </summary>
        [iOSVersion(2)]
        FlexibleRightMargin,

        /// <summary>
        /// Resizing performed by expanding or shrinking a view in the direction of the top margin.
        /// </summary>
        [iOSVersion(2)]
        FlexibleTopMargin,

        /// <summary>
        /// Resizing performed by expanding or shrinking a view's height.
        /// </summary>
        [iOSVersion(2)]
        FlexibleHeight,

        /// <summary>
        /// Resizing performed by expanding or shrinking a view in the direction of the bottom margin.
        /// </summary>
        [iOSVersion(2)]
        FlexibleBottomMargin,
    }
    /// <summary>
    /// Animation transition options for use in an animation block object.
    /// </summary>
    public enum UIViewAnimationTransition
    {
        /// <summary>
        /// The option for indicating that no transition is specified.
        /// </summary>
        [iOSVersion(2)]
        None,

        /// <summary>
        /// A transition that flips a view around a vertical axis from left to right. The left side of the view moves towards the front and right side towards the back.
        /// </summary>
        [iOSVersion(2)]
        FlipFromLeft,

        /// <summary>
        /// A transition that flips a view around a vertical axis from right to left. The right side of the view moves towards the front and left side towards the back.
        /// </summary>
        [iOSVersion(2)]
        FlipFromRight,

        /// <summary>
        /// A transition that curls a view up from the bottom.
        /// </summary>
        [iOSVersion(2)]
        CurlUp,

        /// <summary>
        /// A transition that curls a view down from the top.
        /// </summary>
        [iOSVersion(2)]
        CurlDown,
    }
    /// <summary>
    /// Key frame animation options used with the animateKeyframesWithDuration:delay:options:animations:completion: method.
    /// </summary>
    public enum UIViewKeyframeAnimationOptions
    {
        /// <summary>
        /// The option to lay out subviews at commit time so that they are animated along with their parent.
        /// </summary>
        [iOSVersion(7)]
        LayoutSubviews,

        /// <summary>
        /// The option that allows the user to interact with views while they are being animated.
        /// </summary>
        [iOSVersion(7)]
        AllowUserinteraction,

        /// <summary>
        /// The option to start an animation from the current setting associated with an already in-flight animation. If this option is not present, any in-flight animations are allowed to finish before the new animation is started. If another animation is not in flight, this option has no effect.
        /// </summary>
        [iOSVersion(7)]
        BeginFromCurrentState,

        /// <summary>
        /// The option to repeat an animation indefinitely.
        /// </summary>
        [iOSVersion(7)]
        Repeat,

        /// <summary>
        /// The option to run an animation backwards and forwards. Must be combined with the UIViewKeyframeAnimationOptionRepeat option.
        /// </summary>
        [iOSVersion(7)]
        Autoreverse,

        /// <summary>
        /// The option to force an animation to use the original duration value specified when the animation was submitted. If this option is not present, the animation inherits the remaining duration of the in-flight animation, if any.
        /// </summary>
        [iOSVersion(7)]
        OverrideInheritedDuration,

        /// <summary>
        /// The option to not inherit the animation type or any options.
        /// </summary>
        [iOSVersion(7)]
        OverrideInheritedOptions,

        /// <summary>
        /// The option to use a simple linear calculation when interpolating between keyframe values.
        /// </summary>
        [iOSVersion(7)]
        CalculationModeLinear,

        /// <summary>
        /// The option to not interpolate between keyframe values, but rather to jump directly to each new keyframe value.
        /// </summary>
        [iOSVersion(7)]
        CalculationModeDiscrete,

        /// <summary>
        /// The option to compute intermediate keyframe values using a simple pacing algorithm. This option results in an evenly paced animation.
        /// </summary>
        [iOSVersion(7)]
        CalculationModePaced,

        /// <summary>
        /// The option to compute intermediate frames using a default Catmull-Rom spline that passes through the keyframe values. You cannot adjust the parameters of this algorithm.
        /// </summary>
        [iOSVersion(7)]
        CalculationModeCubic,

        /// <summary>
        /// The option to compute intermediate frames using the cubic scheme while ignoring the timing properties of the animation. Instead, timing parameters are calculated implicitly to give the animation a constant velocity.
        /// </summary>
        [iOSVersion(7)]
        CalculationModeCubicPaced,
    }

    /// <summary>
    /// Keys that specify a horizontal or vertical layout constraint between objects.
    /// </summary>
    public enum UILayoutConstraintAxis
    {
        /// <summary>
        /// The constraint applied when laying out the horizontal relationship between objects.
        /// </summary>
        [iOSVersion(6)]
        Horizontal,

        /// <summary>
        /// The constraint applied when laying out the vertical relationship between objects.
        /// </summary>
        [iOSVersion(6)]
        Vertical,
    }