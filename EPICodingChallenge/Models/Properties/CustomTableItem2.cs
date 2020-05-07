using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPICodingChallenge.Models.Properties
{
    public class CustomTableItem2
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public ContentReference Image { get; set; }
    }
}