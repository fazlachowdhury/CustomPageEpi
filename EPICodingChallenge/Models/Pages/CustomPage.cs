using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPICodingChallenge.Models;
using EPICodingChallenge.Models.Pages;
using EPICodingChallenge.Models.Properties;
using EPiServer.Cms.Shell.UI.ObjectEditing.EditorDescriptors;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
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
        public virtual string Heading { get; set; }

        [Required]
        [Display(
            Name = "Large Image related to topic", 
            Description = "To upload image related to page topic",
            GroupName = Global.GroupNames.Custom,
            Order = 2)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [Required]
        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual XhtmlString MainBody { get; set; }

        [Required]
        [Display(
            Name = "First table",
            Order = 4)]
        [EditorDescriptor(
            EditorDescriptorType = typeof(CollectionEditorDescriptor<CustomTableItem>))]
        public virtual IList<CustomTableItem> Table1Items { get; set; }

        [Required]
        [Display(
            Name = "Second table",
            Order = 5)]
        [EditorDescriptor(
            EditorDescriptorType = typeof(CollectionEditorDescriptor<CustomTableItem2>))]
        public virtual IList<CustomTableItem2> Table2Items { get; set; }

    }
}