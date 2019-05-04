﻿using System;
using System.Collections.Generic;

namespace SuperMaxim.Core.Extensions
{
    public static class CollectionExtensions
    {
        public static object[] ToObjectArray<T>(this T[] source)
        {
            if(source.IsNullOrEmpty())
            {
                return null;
            }
            var copy = new object[source.Length];
            Array.Copy(source, copy, source.Length);
            return copy;
        }

        public static bool IsNullOrEmpty<T>(this ICollection<T> source)
        {
            if(source == null)
            {
                return true;
            }
            if(source.Count < 1)
            {
                return true;
            }
            return false;
        } 
    }
}
