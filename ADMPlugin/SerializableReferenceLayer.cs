﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgGateway.ADAPT.ApplicationDataModel.ReferenceLayers;
using AgGateway.ADAPT.ApplicationDataModel.Representations;

namespace ADMPlugin
{
    public class SerializableReferenceLayer
    {
        public RasterReferenceLayer ReferenceLayer { get; set; }
        public List<SerializableRasterData<string>> StringValues { get; set; }
        public List<SerializableRasterData<EnumerationMember>> EnumerationMemberValues { get; set; }
        public List<SerializableRasterData<NumericValue>> NumericValueValues { get; set; } 
    }
}
