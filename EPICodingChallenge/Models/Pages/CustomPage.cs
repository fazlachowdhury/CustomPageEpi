using System;
using System.ComponentModel.DataAnnotations;
using EPICodingChallenge.Models;
using EPICodingChallenge.Models.Pages;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace EPICodingChallenge
{
    [ContentType(
        GroupName = Global.GroupNames.Custom,
        DisplayName = "Custom Page",
        GUID = "61ce81e8-16db-4d16-b177-9f743e3c15fd",
        Description = "Custom homework page")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "ATB-official-logo.png")]
    public class CustomPage : SitePageData
    {
        [Required]
        [CultureSpecific]
        [Display(
            Name = "Header",
            Description = "Header of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString Heading { get; set; }

        [Display(GroupName = Global.GroupNames.Custom)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [Required]
        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual XhtmlString MainBody { get; set; }

    }
}