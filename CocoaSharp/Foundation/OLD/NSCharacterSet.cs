using ObjectiveC;
        public NSCharacterSet(NSRange range) { }
        public NSCharacterSet(NSData bitmapRepresentation) { }
		/// !! IMPORTANT !! Name the parameter you're using
		/// 
        /// Returns a character set read from the bitmap representation stored in the file a given path or containing the characters in a given string.
        /// <param name="contentsOfFile">A path to a file containing a bitmap representation of a character set. The path name must end with the extension .bitmap.</param>
        /// <param name="charactersInString">A string containing characters for the new character set.</param>
        /// <returns>A character set containing the characters in aString. Returns an empty character set if aString is empty.</returns>
        public NSCharacterSet(string contentsOfFile = "", string charactersInString = "") { }