using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Geometry
{
    public class Polygon : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "geometry_msgs/Polygon";
        public Geometry.Point[] points;

        public Polygon()
        {
            points = new Geometry.Point[0];
        }
    }
}