using EPiServer.Core;
using EPiServer.PlugIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPICodingChallenge.Models.Properties
{
    [PropertyDefinitionTypePlugIn(
        DisplayName = "List of Custom table items. i.e. IList<CustomTableItem>",
        Description = "An editable list of Custom table items.")]
    public class PropertyCustomTableItemList: PropertyList<CustomTableItem>
    {
    }
}