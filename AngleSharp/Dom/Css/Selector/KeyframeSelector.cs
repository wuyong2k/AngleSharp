﻿namespace AngleSharp.Dom.Css
{
    using AngleSharp.Css.Values;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents the keyframe selector.
    /// </summary>
    sealed class KeyframeSelector : IKeyframeSelector
    {
        #region Fields

        readonly List<Percent> _stops;

        #endregion

        #region ctor

        public KeyframeSelector(IEnumerable<Percent> stops)
        {
            _stops = new List<Percent>(stops);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets an enumeration over all stops.
        /// </summary>
        public IEnumerable<Percent> Stops
        {
            get { return _stops; }
        }

        /// <summary>
        /// Gets the text representation of the keyframe selector.
        /// </summary>
        public String Text
        {
            get { return ToCss(); }
        }

        #endregion

        #region String Representation

        public String ToCss()
        {
            var stops = new String[_stops.Count];

            for (int i = 0; i < stops.Length; i++)
                stops[i] = _stops[i].ToString();

            return String.Join(", ", stops);
        }

        public String ToCss(IStyleFormatter formatter)
        {
            return ToCss();
        }

        #endregion
    }
}
