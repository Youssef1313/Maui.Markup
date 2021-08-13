﻿using System;
using System.Collections;
using Microsoft.Maui.Controls;

namespace CommunityToolkit.Maui.Markup
{
    public static class BindableLayoutExtensions
    {
        public static TLayout EmptyView<TLayout>(this TLayout layout, object view) where TLayout : Layout
        {
            var temp = new Grid();
            BindableLayout.SetEmptyView(layout, view);
            return layout;
        }

        public static TLayout EmptyViewTemplate<TLayout>(this TLayout layout, DataTemplate template) where TLayout : Layout
        {
            BindableLayout.SetEmptyViewTemplate(layout, template);
            return layout;
        }

        public static TLayout EmptyViewTemplate<TLayout>(this TLayout layout, Func<object> loadTemplate) where TLayout : Layout
        {
            BindableLayout.SetEmptyViewTemplate(layout, new DataTemplate(loadTemplate));
            return layout;
        }

        public static TLayout ItemsSource<TLayout>(this TLayout layout, IEnumerable source) where TLayout : Layout
        {
            BindableLayout.SetItemsSource(layout, source);
            return layout;
        }

        public static TLayout ItemTemplate<TLayout>(this TLayout layout, DataTemplate template) where TLayout : Layout
        {
            BindableLayout.SetItemTemplate(layout, template);
            return layout;
        }

        public static TLayout ItemTemplate<TLayout>(this TLayout layout, Func<object> loadTemplate) where TLayout : Layout
        {
            BindableLayout.SetItemTemplate(layout, new DataTemplate(loadTemplate));
            return layout;
        }

        public static TLayout ItemTemplateSelector<TLayout>(this TLayout layout, DataTemplateSelector selector) where TLayout : Layout
        {
            BindableLayout.SetItemTemplateSelector(layout, selector);
            return layout;
        }
    }
}