// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace StorageImportExport.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class GetJobResponse
    {
        /// <summary>
        /// Initializes a new instance of the GetJobResponse class.
        /// </summary>
        public GetJobResponse() { }

        /// <summary>
        /// Initializes a new instance of the GetJobResponse class.
        /// </summary>
        public GetJobResponse(string odatametadata = default(string), string odataid = default(string), string odataeditLink = default(string), string name = default(string), JobProperties properties = default(JobProperties), IList<Drive> driveList = default(IList<Drive>), Export export = default(Export))
        {
            Odatametadata = odatametadata;
            Odataid = odataid;
            OdataeditLink = odataeditLink;
            Name = name;
            Properties = properties;
            DriveList = driveList;
            Export = export;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "odata.metadata")]
        public string Odatametadata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "odata.id")]
        public string Odataid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "odata.editLink")]
        public string OdataeditLink { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Properties")]
        public JobProperties Properties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DriveList")]
        public IList<Drive> DriveList { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Export")]
        public Export Export { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.Properties != null)
            {
                this.Properties.Validate();
            }
            if (this.DriveList != null)
            {
                foreach (var element in this.DriveList)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
