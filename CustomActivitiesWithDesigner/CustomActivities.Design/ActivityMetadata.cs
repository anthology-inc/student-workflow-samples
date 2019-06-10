using System.Activities.Presentation.Metadata;
using System.ComponentModel;

namespace CustomActivities.Design
{
    public sealed class ActivityMetadata : IRegisterMetadata
    {
        public void Register()
        {
            var builder = new AttributeTableBuilder();
            builder.AddCustomAttributes(
                typeof (DesignerConvertToJson),
                new DesignerAttribute(typeof (ConvertToJsonDesigner)),
                new DescriptionAttribute("Serializes an object to JSON."));
            MetadataStore.AddAttributeTable(builder.CreateTable());
        }
    }
}