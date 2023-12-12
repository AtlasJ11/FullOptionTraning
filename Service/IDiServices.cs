namespace FullTrailning.Service;

public interface IDiServices
{
    string ShowUserInfo (string userName, int phone);
}

public class DiServices : IDiServices
{
    public string ShowUserInfo(string userName, int phone)
    {
        return $"{userName} , and phoneNumber Is {phone}";
    }
}
