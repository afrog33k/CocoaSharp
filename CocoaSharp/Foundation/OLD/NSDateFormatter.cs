using ObjectiveC;
        public static NSDateFormatterBehavior DefaultFormatterBehavior() { return NSDateFormatterBehavior.BehaviorDefault; }

	    /// <summary>
	    /// The following constants specify predefined format styles for dates and times.
	    /// </summary>
	    [iOSVersion(2)]
	    public enum NSDateFormatterStyle
        {
            /// <summary>
            /// Specifies no style.
            /// Equal to kCFDateFormatterNoStyle.
            /// </summary>
            [iOSVersion(2)]
            NoStyle,

            /// <summary>
            /// Specifies a short style, typically numeric only, such as “11/23/37” or “3:30 PM”.
            /// Equal to kCFDateFormatterShortStyle.
            /// </summary>
            [iOSVersion(2)]
            ShortStyle,

            /// <summary>
            /// Specifies a medium style, typically with abbreviated text, such as “Nov 23, 1937” or “3:30:32 PM”.
            /// Equal to kCFDateFormatterMediumStyle.
            /// </summary>
            [iOSVersion(2)]
            MediumStyle,

            /// <summary>
            /// Specifies a long style, typically with full text, such as “November 23, 1937” or “3:30:32 PM PST”.
            /// Equal to kCFDateFormatterLongStyle.
            /// </summary>
            [iOSVersion(2)]
            LongStyle,

            /// <summary>
            /// Specifies a full style with complete details, such as “Tuesday, April 12, 1952 AD” or “3:30:42 PM Pacific Standard Time”.
            /// Equal to kCFDateFormatterFullStyle.
            /// </summary>
            [iOSVersion(2)]
	        FullStyle
	    }

	    /// <summary>
	    /// Constants that specify the behavior NSDateFormatter should exhibit.
	    /// </summary>
	    [iOSVersion(2)]
	    public enum NSDateFormatterBehavior
	    {
            /// <summary>
            /// Specifies default formatting behavior.
            /// </summary>
            [iOSVersion(2)]
            BehaviorDefault,
            /// Specifies formatting behavior equivalent to that in OS X v10.0.
            /// Not available in iOS > 2.1
            /// </summary>
            //[iOSVersion(2)]
            /// Specifies formatting behavior equivalent for OS X v10.4.
            /// </summary>
            [iOSVersion(2)]