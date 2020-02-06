using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Navigation
{
    public class Path : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "nav_msgs/Path";
        public Standard.Header header;
        public Geometry.PoseStamped[] poses;

        public Path()
        {
            header = new Standard.Header();
            poses = new Geometry.PoseStamped[0];
        }
    }
}