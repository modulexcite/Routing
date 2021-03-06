// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Framework.Internal;

namespace Microsoft.AspNet.Routing.Constraints
{
    /// <summary>
    /// Represents a regex constraint which can be used as an inlineConstraint.
    /// </summary>
    public class RegexInlineRouteConstraint : RegexRouteConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegexInlineRouteConstraint" /> class.
        /// </summary>
        /// <param name="regexPattern">The regular expression pattern to match.</param>
        public RegexInlineRouteConstraint([NotNull] string regexPattern)
            : base(regexPattern)
        {
        }
    }
}
