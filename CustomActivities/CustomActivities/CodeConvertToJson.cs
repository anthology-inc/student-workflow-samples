using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Activities;
using System.Drawing;

namespace CustomActivities
{
    [ToolboxBitmap(typeof(CodeConvertToJson), "ConvertToJson.png")]
    public class CodeConvertToJson : CodeActivity<string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodeConvertToJson" /> class.
        /// </summary>
        public CodeConvertToJson()
        {
        }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        [RequiredArgument]
        public InArgument<object> Object { get; set; }

        /// <summary>
        /// When implemented in a derived class, performs the execution of the activity.
        /// </summary>
        /// <param name="context">The execution context under which the activity executes.</param>
        /// <returns>
        /// The result of the activity’s execution.
        /// </returns>
        protected override string Execute(CodeActivityContext context)
        {
            var instance = Object.Get(context);
            return instance == null ? "null" : JsonConvert.SerializeObject(instance, Formatting.Indented,
                new JsonSerializerSettings() { ContractResolver = new CamelCasePropertyNamesContractResolver() });
        }
    }
}
