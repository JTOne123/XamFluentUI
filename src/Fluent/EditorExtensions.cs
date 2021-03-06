﻿using Xamarin.Forms;

namespace Fluent
{
    public static class EditorExtensions
    {
        public static Editor AutoSize(this Editor editor, EditorAutoSizeOption autoSize)
        {
            editor.AutoSize = autoSize;
            return editor;
        }

        public static Editor FontAttributes(this Editor editor, FontAttributes attributes)
        {
            editor.FontAttributes = attributes;
            return editor;
        }

        public static Editor FontFamily(this Editor editor, string fontFamily)
        {
            editor.FontFamily = fontFamily;
            return editor;
        }

        public static Editor FontSize(this Editor editor, double size)
        {
            editor.FontSize = size;
            return editor;
        }
    }
}