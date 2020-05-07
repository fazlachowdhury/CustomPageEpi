using System;
using System.ComponentModel.DataAnnotations;
using EPICodingChallenge.Models;
using EPICodingChallenge.Models.Pages;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EPICodingChallenge
{
    [ContentType(
        GroupName = Global.GroupNames.Custom,
        DisplayName = "Custom Page", 
        GUID = "025e35bb-0f00-40b7-884e-20d8131c8dc1", 
        Description = "Custom homework page")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "ATB-official-logo.png")]
    public class CustomPage : SitePageData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
         */
    }
}