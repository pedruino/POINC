using Poinc.Domain.Builder;
using System;

namespace Poinc.Domain.Extensions
{
    public static class BuilderExtensions
    {
        public static TBuilder SetProperty<TBuilder, TProperty>(this TBuilder obj, Func<TProperty> property) where TBuilder : IBuilder
        {
            property.Invoke();
            return obj;
        }

        internal static TBuilder SetProperty<TBuilder, TProperty>(this TBuilder builder, ref TProperty property, TProperty value) where TBuilder : IBuilder
        {
            property = value;
            return builder;
        }
    }
}