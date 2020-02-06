using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Geometry
{
    public class Polygon : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "geometry_msgs/Polygon";
        public Point32[] points;

        public Polygon()
        {
            points = new Point32[0];
        }
    }
}