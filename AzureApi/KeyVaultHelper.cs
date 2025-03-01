using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

namespace AzureApi
{
    public class KeyVaultHelper
    {
        private string keyVaultUrl = "https://mysqldbconnectionstring.vault.azure.net/";

        public string GetConnectionString()
        {
            var client = new SecretClient(new Uri(keyVaultUrl), new DefaultAzureCredential());
            KeyVaultSecret secret = client.GetSecret("MyDbConnectionString");

            return secret.Value;
        }
    }
}
