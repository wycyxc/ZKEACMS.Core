/* http://www.zkea.net/ Copyright 2016 ZKEASOFT http://www.zkea.net/licenses */
using Easy.MetaData;
using Easy.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZKEACMS.Theme
{
    [Table("CMS_Theme")]
    public class ThemeEntity : EditorEntity
    {
        public const string DefaultThumbnail = "~/Content/Images/theme.jpg";
        [Key]
        public string ID { get; set; }
        public string Url { get; set; }
        public string UrlDebugger { get; set; }
        public string Thumbnail { get; set; }
        public bool IsActived { get; set; }
        [NotMapped]
        public bool IsPreView { get; set; }

    }

    class ThemeEntityMetaData : ViewMetaData<ThemeEntity>
    {
        protected override void ViewConfigure()
        {
            ViewConfig(m => m.ID).AsHidden();
            ViewConfig(m => m.Title).AsTextBox().Required();
            ViewConfig(m => m.Url).AsTextBox().Required().AddClass(StringKeys.SelectImageClass).AddProperty("data-url", Urls.SelectMedia); ;
            ViewConfig(m => m.Thumbnail).AsTextBox().Required().AddClass(StringKeys.SelectImageClass).AddProperty("data-url", Urls.SelectMedia); ;
            ViewConfig(m => m.Description).AsTextArea();
        }
    }
}
