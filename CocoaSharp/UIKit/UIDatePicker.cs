using ObjectiveC;

    /// <summary>
    /// The mode of the date picker.
    /// </summary>
    public enum UIDatePickerMode
    {
        /// <summary>
        /// The date picker displays hours, minutes, and (optionally) an AM/PM designation. The exact items shown and their order depend upon the locale set. An example of this mode is [ 6 | 53 | PM ].
        /// </summary>
        [iOSVersion(2)]
        Time,

        /// <summary>
        /// The date picker displays months, days of the month, and years. The exact order of these items depends on the locale setting. An example of this mode is [ November | 15 | 2007 ].
        /// </summary>
        [iOSVersion(2)]
        Date,

        /// <summary>
        /// The date picker displays dates (as unified day of the week, month, and day of the month values) plus hours, minutes, and (optionally) an AM/PM designation. The exact order and format of these items depends on the locale set. An example of this mode is [ Wed Nov 15 | 6 | 53 | PM ].
        /// </summary>
        [iOSVersion(2)]
        DateAndTime,

        /// <summary>
        /// The date picker displays hour and minute values, for example [ 1 | 53 ]. The application must set a timer to fire at the proper interval and set the date picker as the seconds tick down.
        /// </summary>
        [iOSVersion(2)]
        CountDownTimer,
    }