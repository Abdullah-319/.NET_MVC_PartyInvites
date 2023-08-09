using System.Xml.Serialization;

namespace PartyInvites.Models
{
    public class Repository
    {
        private static List<GuestResponse> _responses = new ();
        public static IEnumerable<GuestResponse> list => _responses;
        public static void AddRespose(GuestResponse response)
        {
            Console.WriteLine(response);
            _responses.Add(response);
        }
    }
}
