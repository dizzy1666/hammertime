using Sledge.BspEditor.Primitives.MapData;
using Sledge.Common.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Sledge.BspEditor.Primitives.MapObjects
{
	[Serializable]
	public class GroupFlags : IMapData
	{
		public bool AffectsRendering => false;
		public bool IgnoreGrouping { get; set; }


		public IMapElement Clone()
		{
			return new GroupFlags() { IgnoreGrouping = IgnoreGrouping, };
		}

		public IMapElement Copy(UniqueNumberGenerator numberGenerator)
		{
			return Clone();
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("IgnoreGrouping", IgnoreGrouping);
		}

		public SerialisedObject ToSerialisedObject()
		{
			var so = new SerialisedObject("GroupingFlags");
			so.Set("IgnoreGrouping", IgnoreGrouping);
			return so;
		}
        public GroupFlags()
        {
            
        }
        public GroupFlags(SerialisedObject so)
        {
			IgnoreGrouping = so.Get<bool>("IgnoreGrouping");
        }
    }
}
