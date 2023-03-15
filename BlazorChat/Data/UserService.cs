namespace BlazorChat.Data
{
    public class UserService
    {
        private Dictionary<string, string> _users = new Dictionary<string, string>();

        public void Add(string connectionId, string username)
        {
            _users.Add(connectionId, username);
        }

        public void RemoveByName(string username)
        {
            _users.Remove(username);
        }

        public string GetConnectionIdByName(string username)
        {
            return _users.TryGetValue(username, out var value) ? value : string.Empty;
        }

        public IEnumerable<(string ConnectionId, string Username)> GetAll()
        {
            return _users.Select(e => (e.Value, e.Key));
        }
    }
}
