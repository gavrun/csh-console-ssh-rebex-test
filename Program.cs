namespace console_test_ssh;

using Rebex.Net;

class Program
{
    static void Main(string[] args)
    {
    Rebex.Licensing.Key = "==AtSq7tp6rZ/lx+I+ucuxMbKpj1cXScxPQ/5Wx/9K8c4c==";
    Sftp ssh = new Sftp();
        try
        {
            ssh.Connect("172.24.214.20");
            ssh.Login("user", "user");
            Console.WriteLine("Connected successfully!");
            ssh.Disconnect();
        }
        catch (SshException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
