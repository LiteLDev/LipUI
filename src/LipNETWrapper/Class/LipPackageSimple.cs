using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace LipNETWrapper.Class
{
    /*[
      {
          "tooth": "github.com/tooth-hub/bds",
          "version": "1.19.61"
      },
      {
          "tooth": "github.com/tooth-hub/bdsdownloader",
          "version": "0.1.0"
      },
      {
          "tooth": "github.com/tooth-hub/liteloaderbds",
          "version": "2.10.0"
      },
      {
          "tooth": "github.com/tooth-hub/llessentials",
          "version": "2.10.0"
      }
  ]*/
    [Serializable]
    public class LipPackageSimple
    {
        [JsonProperty("tooth")] public string Tooth { get; set; } = string.Empty;
        [JsonProperty("version")] public string Version { get; set; } = string.Empty;
        [JsonProperty("information")] public LipPackageSimpleInformation Information { get; set; } = new();
        public class LipPackageSimpleInformation
        {
            //"information": {
            //    "author": "Igor Pavlov.",
            //    "description": "7-Zip for Lip",
            //    "homepage": "https://www.7-zip.org/",
            //    "license": "LGPL-2.1",
            //    "name": "7-Zip Lip Tool"
            //}
            [JsonProperty("author")] public string Author { get; set; } = string.Empty;
            [JsonProperty("description")] public string Description { get; set; } = string.Empty;
            [JsonProperty("homepage")] public string Homepage { get; set; } = string.Empty;
            [JsonProperty("license")] public string License { get; set; } = string.Empty;
            [JsonProperty("name")] public string Name { get; set; } = string.Empty;
        }
    }
}
