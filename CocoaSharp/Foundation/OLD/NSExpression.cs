using ObjectiveC;
        /// !! IMPORTANT !! Don't use the third argument
        /// 
        /// !! IMPORTANT !! Name the parameter that you're using!
        /// 
        /// !! IMPORTANT !! Name the paramters that you're using!
        /// 

        /// <summary>
        /// Defines the possible types of NSExpression.
        /// </summary>
        [iOSVersion(3)]
        public enum NSExpressionType
        {
            ConstantValueExpressionType,
            EvaluatedObjectExpressionType,
            VariableExpressionType,
            KeyPathExpressionType,
            FunctionExpressionType,
            UnionSetExpressionType,
            intersectSetExpressionType,
            MinusSetExpressionType,
            SubqueryExpressionType,
            AggregateExpressionType,
            AnyKeyExpressionType,
            BlockExpressionType
    }