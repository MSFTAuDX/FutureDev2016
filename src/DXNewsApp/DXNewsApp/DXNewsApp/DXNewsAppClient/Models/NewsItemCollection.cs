﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using DXNewsApp.Models;
using Newtonsoft.Json.Linq;

namespace DXNewsApp.Models
{
    public static partial class NewsItemCollection
    {
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public static IList<NewsItem> DeserializeJson(JToken inputObject)
        {
            IList<NewsItem> deserializedObject = new List<NewsItem>();
            foreach (JToken iListValue in ((JArray)inputObject))
            {
                NewsItem newsItem = new NewsItem();
                newsItem.DeserializeJson(iListValue);
                deserializedObject.Add(newsItem);
            }
            return deserializedObject;
        }
    }
}
