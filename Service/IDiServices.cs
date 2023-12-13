namespace FullTrailning.Service;

public interface IDiServices
{
    string ShowUserInfo (string userName, int age);
}

public class DiServices : IDiServices
{
    public string ShowUserInfo(string userName, int age)
    {
        return $"{userName} , and phoneNumber Is {age}";
    }
}
