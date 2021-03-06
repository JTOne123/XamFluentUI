﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Fluent
{
    public static class LayoutExtensions
    {
        public static T CascadeInputTransparent<T>(this T layout, bool transparent) where T : Layout
        {
            layout.CascadeInputTransparent = transparent;
            return layout;
        }

        public static Layout CascadeInputTransparent(this Layout layout, bool transparent)
        {
            layout.CascadeInputTransparent = transparent;
            return layout;
        }

        public static T IsClippedToBounds<T>(this T layout, bool clipped) where T : Layout
        {
            layout.IsClippedToBounds = clipped;
            return layout;
        }

        public static Layout IsClippedToBounds(this Layout layout, bool clipped)
        {
            layout.IsClippedToBounds = clipped;
            return layout;
        }

        public static T Padding<T>(this T layout, double uniformSize) where T : Layout
        {
            layout.Padding = new Thickness(uniformSize);
            return layout;
        }

        public static Layout Padding(this Layout layout, double uniformSize)
        {
            layout.Padding = new Thickness(uniformSize);
            return layout;
        }

        public static T Padding<T>(this T layout, double horizontal, double vertical) where T : Layout
        {
            layout.Padding = new Thickness(horizontal, vertical);
            return layout;
        }

        public static Layout Padding(this Layout layout, double horizontal, double vertical)
        {
            layout.Padding = new Thickness(horizontal, vertical);
            return layout;
        }

        public static T Padding<T>(this T layout, double left, double top, double right, double bottom) where T : Layout
        {
            layout.Padding = new Thickness(left, top, right, bottom);
            return layout;
        }

        public static Layout Padding(this Layout layout, double left, double top, double right, double bottom)
        {
            layout.Padding = new Thickness(left, top, right, bottom);
            return layout;
        }

        public static Layout<View> AddContent(this Layout<View> layout, Func<IList<View>> views)
        {
            views.Invoke().ForEach(x => layout.Children.Add(x));
            return layout;
        }

        public static Layout<View> AddContent(this Layout<View> layout, Func<View> view)
        {
            layout.Children.Add(view.Invoke());
            return layout;
        }

        public static Layout<View> AddContent(this Layout<View> layout, params View[] views)
        {
            views.ForEach(x => layout.Children.Add(x));
            return layout;
        }

        public static Layout<View> AddContent(this Layout<View> layout, View view)
        {
            layout.Children.Add(view);
            return layout;
        }
    }
}